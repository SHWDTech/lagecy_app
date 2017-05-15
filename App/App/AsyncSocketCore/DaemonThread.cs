using System;
using System.Threading;

namespace ESMonApp.AsyncSocketCore
{
    internal class DaemonThread : object
    {
        private readonly Thread _mThread;
        private readonly AsyncSocketServer _mAsyncSocketServer;

        public DaemonThread(AsyncSocketServer asyncSocketServer)
        {
            _mAsyncSocketServer = asyncSocketServer;
            _mThread = new Thread(DaemonThreadStart);
            _mThread.Start();
        }

        public void DaemonThreadStart()
        {
            while (_mThread.IsAlive)
            {
                AsyncSocketUserToken[] userTokenArray = null;
                _mAsyncSocketServer.AsyncSocketUserTokenList.CopyList(ref userTokenArray);
                for (var i = 0; i < userTokenArray.Length; i++)
                {
                    if (!_mThread.IsAlive)
                        break;
                    try
                    {
                        //判断通信超时
                        if (((userTokenArray[i].State && (DateTime.Now - userTokenArray[i].ActiveDateTime).TotalMilliseconds >
                            _mAsyncSocketServer.SocketTimeOutMs)) || (((userTokenArray[i].State==false) && (DateTime.Now - userTokenArray[i].ConnectDateTime).TotalMilliseconds >
                            _mAsyncSocketServer.SocketTimeOutMs)))//超时Socket断开
                        {
                            lock (userTokenArray[i])
                            {
                                _mAsyncSocketServer.CloseClientSocket(userTokenArray[i]);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Program.Logger.ErrorFormat("Daemon thread check timeout socket error, message: {0}", e.Message);
                        Program.Logger.Error(e.StackTrace);

                        Program.OutputLog.LogFormat("Daemon thread check timeout socket error, message: {0}", e.Message);
                    }
                }

                if (!_mThread.IsAlive)
                    break;
                Thread.Sleep(60000); //每分钟检测一次
            }
        }

        public void Close()
        {
            _mThread.Abort();
            _mThread.Join();
        }
    }
}
