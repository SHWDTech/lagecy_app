using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using ESMonApp.AsyncSocketProtocol;
using ESMonApp.AsyncSocketProtocolCore;
using ESMonApp.ScheduleTasks;

namespace ESMonApp.AsyncSocketCore
{
    public class AsyncSocketServer
    {

         public AsyncSocketServer(int numConnections)
         {
             _mIsStarted = false;
             _mNumConnections = numConnections;
             _mReceiveBufferSize = ProtocolConst.ReceiveBufferSize;

             _mAsyncSocketUserTokenPool = new AsyncSocketUserTokenPool(numConnections);
             AsyncSocketUserTokenList = new AsyncSocketUserTokenList();
             _mMaxNumberAcceptedClients = new Semaphore(numConnections, numConnections);
         }

        private Socket _listenSocket;
        private bool _mIsStarted; //是否已经启动服务
        private readonly int _mNumConnections; //最大支持连接个数
        private readonly int _mReceiveBufferSize; //每个连接接收缓存大小
        private readonly Semaphore _mMaxNumberAcceptedClients; //限制访问接收连接的线程数，用来控制最大并发数

        public int SocketTimeOutMs { get; set; }

        public int WaitResponseTimeOutMs { get; set; }

        private readonly AsyncSocketUserTokenPool _mAsyncSocketUserTokenPool;
        public AsyncSocketUserTokenList AsyncSocketUserTokenList { get; }

        public EsProtocolMgr EsProtocolMgr { get; private set; }

        private DaemonThread _mDaemonThread;

        public void Init()
        {
            for (var i = 0; i < _mNumConnections; i++) //按照连接数建立读写对象
            {
                var userToken = new AsyncSocketUserToken(_mReceiveBufferSize);
                userToken.ReceiveEventArgs.Completed += IO_Completed;
                userToken.SendEventArgs.Completed += IO_Completed;
                _mAsyncSocketUserTokenPool.Push(userToken);
            }

            var adjustTimeSchedule = new ScheduleTask(TimeSpan.TicksPerDay, true, ScheduleType.StartOnCondition);
            adjustTimeSchedule.OnScheduleExecuting += delegate 
            {
                AsyncSocketUserTokenList.AdjestTime();
            };
            adjustTimeSchedule.StartCondition = running =>
            {
                if(running) return true;
                return DateTime.Now.Hour == 3 && DateTime.Now.Second < 30;
            };
            ScheduleManager.Register(adjustTimeSchedule);

            EsProtocolMgr = new EsProtocolMgr();
        }

        public bool Start(IPEndPoint localEndPoint)
        {
            var ret = false;
            if (_mIsStarted) return false;
            _listenSocket = new Socket(localEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                
            try
            {
                _listenSocket.Bind(localEndPoint);

                _listenSocket.Listen(_mNumConnections);
                Program.Logger.InfoFormat($"Start listen socket {localEndPoint} success");
                Program.OutputLog.LogFormat("Start listen socket {0} success", localEndPoint.ToString());

                //for (int i = 0; i < 64; i++) //不能循环投递多次AcceptAsync，会造成只接收8000连接后不接收连接了
                StartAccept(null);
                _mDaemonThread = new DaemonThread(this);

                _mIsStarted = true;

                ScheduleManager.Start();
                    
                ret = true;
            }
            catch (Exception ex)
            {
                Program.Logger.InfoFormat($"Start listen socket {localEndPoint} error", ex);
                Program.OutputLog.LogFormat("Start listen socket {0} error", localEndPoint.ToString());
            }

            return ret;
        }

        public bool Stop()
        {
            var ret = false;
            
            if (_mIsStarted)
            {
                _listenSocket.Close();
                _mDaemonThread.Close();

                _listenSocket = null;
                _mDaemonThread = null;

                _mIsStarted = false;

                ScheduleManager.Stop();

                ret = true;
            }
            
            return ret;
        }

        public void StartAccept(SocketAsyncEventArgs acceptEventArgs)
        {
            if (acceptEventArgs == null)
            {
                acceptEventArgs = new SocketAsyncEventArgs();
                acceptEventArgs.Completed += AcceptEventArg_Completed;//
            }
            else
            {
                acceptEventArgs.AcceptSocket = null; //释放上次绑定的Socket，等待下一个Socket连接
            }

            _mMaxNumberAcceptedClients.WaitOne(); //获取信号量
            var willRaiseEvent = _listenSocket.AcceptAsync(acceptEventArgs);//同步才是false，大多数的情况下都是异步的
            if (!willRaiseEvent)
            {
                ProcessAccept(acceptEventArgs);
            }
        }

        void AcceptEventArg_Completed(object sender, SocketAsyncEventArgs acceptEventArgs)
        {
            try
            {
                ProcessAccept(acceptEventArgs);
            }
            catch (Exception e)
            {
                Program.Logger.ErrorFormat("Accept client {0} error, message: {1}", acceptEventArgs.AcceptSocket, e.Message);
                Program.Logger.Error(e.StackTrace);

                Program.OutputLog.LogFormat("Accept client {0} error, message: {1}", acceptEventArgs.AcceptSocket, e.Message);   
            }            
        }

        private void ProcessAccept(SocketAsyncEventArgs acceptEventArgs)
        {
            Program.Logger.InfoFormat("Client connection accepted. Local Address: {0}, Remote Address: {1}",
                acceptEventArgs.AcceptSocket.LocalEndPoint, acceptEventArgs.AcceptSocket.RemoteEndPoint);
                
            Program.OutputLog.LogFormat("Client connection accepted. Local Address: {0}, Remote Address: {1}",
                acceptEventArgs.AcceptSocket.LocalEndPoint, acceptEventArgs.AcceptSocket.RemoteEndPoint);

            var userToken = _mAsyncSocketUserTokenPool.Pop();
            AsyncSocketUserTokenList.Add(userToken); //添加到正在连接列表
            userToken.ConnectSocket = acceptEventArgs.AcceptSocket;
            userToken.ConnectDateTime = DateTime.Now;

            try
            {
                var willRaiseEvent = userToken.ConnectSocket.ReceiveAsync(userToken.ReceiveEventArgs); //投递接收请求
                if (!willRaiseEvent)
                {
                    lock (userToken)
                    {
                        ProcessReceive(userToken.ReceiveEventArgs);
                    }
                }                    
            }
            catch (Exception e)
            {
                Program.Logger.ErrorFormat("Accept client {0} error, message: {1}", userToken.ConnectSocket, e.Message);
                Program.Logger.Error(e.StackTrace);
                
                Program.OutputLog.LogFormat("Accept client {0} error, message: {1}", userToken.ConnectSocket, e.Message);                
            }            

            StartAccept(acceptEventArgs); //把当前异步事件释放，等待下次连接
        }

        void IO_Completed(object sender, SocketAsyncEventArgs asyncEventArgs)
        {
            var userToken = asyncEventArgs.UserToken as AsyncSocketUserToken;
            //userToken.ActiveDateTime = DateTime.Now;
            
            try
            {
                if (userToken == null) return;
                lock (userToken)
                {
                    switch (asyncEventArgs.LastOperation)
                    {
                        case SocketAsyncOperation.Receive:
                            ProcessReceive(asyncEventArgs);
                            break;
                        case SocketAsyncOperation.Send:
                            ProcessSend(asyncEventArgs);
                            break;
                        default:
                            throw new ArgumentException("The last operation completed on the socket was not a receive or send");
                    }
                }
            }
            catch (Exception e)
            {
                if (userToken != null)
                    Program.Logger.ErrorFormat("IO_Completed {0} error, message: {1}", userToken.ConnectSocket, e.Message);
                Program.Logger.Error(e.StackTrace);
            }                     
        }

        private void ProcessReceive(SocketAsyncEventArgs receiveEventArgs)
        {
            var userToken = (AsyncSocketUserToken)receiveEventArgs.UserToken;//接受事件的用户令牌就等于自身
            
            
            if (userToken.ConnectSocket == null)
            {
                return;
            }

            if (userToken.ReceiveEventArgs.BytesTransferred >= 0 && userToken.ReceiveEventArgs.SocketError == SocketError.Success)
            {
                var offset = userToken.ReceiveEventArgs.Offset;
                var count = userToken.ReceiveEventArgs.BytesTransferred;

                if ((userToken.AsyncSocketInvokeElement == null) & (userToken.ConnectSocket != null)) //存在Socket对象，并且没有绑定协议对象，则进行协议对象绑定
                {
                    BuildingSocketInvokeElement(userToken);
                }

                if (userToken.AsyncSocketInvokeElement == null) //如果没有解析对象，提示非法连接并关闭连接
                {
                    Program.Logger.WarnFormat("Illegal client connection. Local Address: {0}, Remote Address: {1}", userToken.ConnectSocket.LocalEndPoint, 
                        userToken.ConnectSocket.RemoteEndPoint);

                    CloseClientSocket(userToken);
                }
                else
                {
                    if (count > 0) //处理接收数据
                    {
                        var rxStatus = userToken.AsyncSocketInvokeElement.ProcessReceive(userToken.ReceiveEventArgs.Buffer, offset, count);
                        
                        //处理数据返回失败，丢包
                        if (rxStatus)
                        {
                            userToken.ActiveDateTime = DateTime.Now;
                            userToken.State = true;
                            var willRaiseEvent = userToken.ConnectSocket.ReceiveAsync(userToken.ReceiveEventArgs); //投递接收请求
                            if (!willRaiseEvent)
                            {
                                ProcessReceive(userToken.ReceiveEventArgs);
                            }
                        }
                    }
                    else
                    {
                        var willRaiseEvent = userToken.ConnectSocket.ReceiveAsync(userToken.ReceiveEventArgs); //投递接收请求
                        if (!willRaiseEvent)
                        {
                            ProcessReceive(userToken.ReceiveEventArgs);
                        }
                    }
                }
            }
            else
            {
                CloseClientSocket(userToken);
                Program.Logger.InfoFormat("Received Bytes: {0}, Socket Error: {1}", userToken.ReceiveEventArgs.BytesTransferred, userToken.ReceiveEventArgs.SocketError);
                Program.OutputLog.LogFormat("Received Bytes: {0}, Socket Error: {1}", userToken.ReceiveEventArgs.BytesTransferred, userToken.ReceiveEventArgs.SocketError);
            }
        }

        private void BuildingSocketInvokeElement(AsyncSocketUserToken userToken)
        {
            userToken.AsyncSocketInvokeElement = new EsProtocol(this, userToken);
            if (userToken.AsyncSocketInvokeElement != null)
            {
                Program.Logger.InfoFormat("Building socket invoke element {0}.Local Address: {1}, Remote Address: {2}",
                    userToken.AsyncSocketInvokeElement, userToken.ConnectSocket.LocalEndPoint, userToken.ConnectSocket.RemoteEndPoint);
            } 
        }

        private bool ProcessSend(SocketAsyncEventArgs sendEventArgs)
        {
            var userToken = sendEventArgs.UserToken as AsyncSocketUserToken;
            if (userToken != null && userToken.AsyncSocketInvokeElement == null)
            {
                return false;
            }

//            userToken.ActiveDateTime = DateTime.Now;

            if (sendEventArgs.SocketError == SocketError.Success)
            {
                return userToken != null && userToken.AsyncSocketInvokeElement.SendCompleted(); //调用子类回调函数
            }
            CloseClientSocket(userToken);
            if (userToken == null) return false;
            Program.Logger.InfoFormat($"Socket Error: {userToken.ReceiveEventArgs.SocketError}");
            Program.OutputLog.LogFormat("Socket Error: {0}", userToken.ReceiveEventArgs.SocketError);
            return false;
        }

        public bool SendAsyncEvent(Socket connectSocket, SocketAsyncEventArgs sendEventArgs, byte[] buffer, int offset, int count)
        {
            if (connectSocket == null)
            {
                return false;
            }
            
            sendEventArgs.SetBuffer(buffer, offset, count);
            var willRaiseEvent = connectSocket.SendAsync(sendEventArgs);
            return willRaiseEvent || ProcessSend(sendEventArgs);
        }

        public void CloseClientSocket(AsyncSocketUserToken userToken)
        {
            if (userToken.ConnectSocket == null)
            {
                return;
            }

            var socketInfo =
                $"Local Address: {userToken.ConnectSocket.LocalEndPoint} Remote Address: {userToken.ConnectSocket.RemoteEndPoint}";
            Program.Logger.InfoFormat("Client connection disconnected. {0}", socketInfo);

            Program.OutputLog.LogFormat("Client connection disconnected. {0}", socketInfo);

            //if (!userToken.ConnectSocket.Connected)
            //{
            //    return;
            //}

            //try
            //{
            //    //userToken.ConnectSocket.Shutdown(SocketShutdown.Both);
            //}
            //catch (Exception E) 
            //{
            //    Program.Logger.ErrorFormat("CloseClientSocket Disconnect client {0} error, message: {1}", socketInfo, E.Message);

            //    Program.OutputLog.LogFormat("CloseClientSocket Disconnect client {0} error, message: {1}", socketInfo, E.Message);   
            //}

            ////userToken.ConnectSocket.Close();
            //userToken.ConnectSocket.Close();
            //userToken.ConnectSocket = null; //释放引用，并清理缓存，包括释放协议对象等资源
            //userToken.State = false;
            //m_maxNumberAcceptedClients.Release();
            //m_asyncSocketUserTokenPool.Push(userToken);
            //m_asyncSocketUserTokenList.Remove(userToken);


            if (userToken.ConnectSocket.Connected)
            {
                try
                {
                    userToken.ConnectSocket.Shutdown(SocketShutdown.Both);
                }
                catch (Exception e)
                {
                    Program.Logger.ErrorFormat("CloseClientSocket Disconnect client {0} error, message: {1}", socketInfo, e.Message);

                    Program.OutputLog.LogFormat("CloseClientSocket Disconnect client {0} error, message: {1}", socketInfo, e.Message);
                }

                userToken.ConnectSocket.Close();
            }

            userToken.ConnectSocket = null; //释放引用，并清理缓存，包括释放协议对象等资源
            userToken.ReceiveBuffer.Clear(userToken.ReceiveBuffer.DataCount);
            userToken.SendBuffer.ClearPacket();

            _mMaxNumberAcceptedClients.Release();
            _mAsyncSocketUserTokenPool.Push(userToken);
            AsyncSocketUserTokenList.Remove(userToken);
        }
    }
}
