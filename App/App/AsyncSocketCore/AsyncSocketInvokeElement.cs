using System;
using System.Diagnostics;
using ESMonApp.AsyncSocketPublic;

namespace ESMonApp.AsyncSocketCore
{
    //异步Socket调用对象，所有的协议处理都从本类继承
    public class AsyncSocketInvokeElement
    {
        protected AsyncSocketServer MAsyncSocketServer;
        protected AsyncSocketUserToken MAsyncSocketUserToken;
        public AsyncSocketUserToken AsyncSocketUserToken => MAsyncSocketUserToken;
        protected bool MSendAsync; //标识是否有发送异步事件

        public AsyncSocketInvokeElement(AsyncSocketServer asyncSocketServer, AsyncSocketUserToken asyncSocketUserToken)
        {
            MAsyncSocketServer = asyncSocketServer;
            MAsyncSocketUserToken = asyncSocketUserToken;

            MSendAsync = false;
        }

        public virtual void Close()
        {
            MAsyncSocketServer.CloseClientSocket(MAsyncSocketUserToken);
        }

        public virtual bool ProcessReceive(byte[] buffer, int offset, int count) //接收异步事件返回的数据，用于对数据进行缓存和分包
        {
            //m_activeDT = DateTime.Now;
            Debug.WriteLine("收到TCP数据。");
            var receiveBuffer = MAsyncSocketUserToken.ReceiveBuffer;
            Debug.WriteLine($"buffer{BitConverter.ToString(buffer).Replace("-", " ")}:, count:{count}.");
            receiveBuffer.WriteBuffer(buffer, offset, count);

            if (receiveBuffer.DataCount >= BasicFunc.MinPacketLength)
            {
                var packetLength = 0;

                if (!BasicFunc.CheckPacket(buffer, ref packetLength))
                {
                    return true;
                }

                if (receiveBuffer.DataCount >= packetLength) //收到的数据达到包长度
                {
                    var result = ProcessPacket(receiveBuffer.Buffer, 0, packetLength);

                    if (result)
                        receiveBuffer.Clear(packetLength); //从缓存中清理
                    return result;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public virtual bool ProcessPacket(byte[] buffer, int offset, int packetLen) //处理分完包后的数据，把命令和数据分开，并对命令进行解析
        {
            return ProcessCommand(buffer, offset, packetLen); //处理命令
        }

        public virtual bool ProcessCommand(byte[] buffer, int offset, int count) //处理具体命令，子类从这个方法继承，buffer是收到的数据
        {
            return true;
        }

        public virtual bool SendCompleted()
        {
            MSendAsync = false;
            var asyncSendBufferManager = MAsyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.ClearFirstPacket(); //清除已发送的包
            return SendCallback();
        }

        //发送回调函数，用于连续下发数据
        public virtual bool SendCallback()
        {
            return true;
        }

        public bool DoSendResult(byte[] buffer, int offset, int count)
        {
            //计算CRC
            var asyncSendBufferManager = MAsyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.StartPacket();
            asyncSendBufferManager.DynamicBufferManager.WriteBuffer(buffer, offset, count);
            asyncSendBufferManager.EndPacket();

            var result = true;
            if (!MSendAsync)
            {
                var packetOffset = 0;
                var packetCount = 0;
                if (asyncSendBufferManager.GetFirstPacket(ref packetOffset, ref packetCount))
                {
                    MSendAsync = true;
                    result = MAsyncSocketServer.SendAsyncEvent(MAsyncSocketUserToken.ConnectSocket, MAsyncSocketUserToken.SendEventArgs,
                        asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                }
            }
            return result;
        }

        public bool DoSendBuffer(byte[] buffer, int offset, int count)
        {
            var asyncSendBufferManager = MAsyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.StartPacket();
            asyncSendBufferManager.DynamicBufferManager.WriteBuffer(buffer, offset, count);
            asyncSendBufferManager.EndPacket();

            var result = true;
            if (!MSendAsync)
            {
                var packetOffset = 0;
                var packetCount = 0;
                if (asyncSendBufferManager.GetFirstPacket(ref packetOffset, ref packetCount))
                {
                    MSendAsync = true;
                    result = MAsyncSocketServer.SendAsyncEvent(MAsyncSocketUserToken.ConnectSocket, MAsyncSocketUserToken.SendEventArgs,
                        asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                }
            }
            return result;
        }
    }
}