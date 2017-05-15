using System;
using System.Net.Sockets;
using ESMonApp.AsyncSocketProtocolCore;

namespace ESMonApp.AsyncSocketCore
{
    public class AsyncSocketUserToken
    {
        protected SocketAsyncEventArgs MReceiveEventArgs;
        public SocketAsyncEventArgs ReceiveEventArgs { get { return MReceiveEventArgs; } set { MReceiveEventArgs = value; } }
        protected byte[] MAsyncReceiveBuffer;
        protected SocketAsyncEventArgs MSendEventArgs;
        public SocketAsyncEventArgs SendEventArgs { get { return MSendEventArgs; } set { MSendEventArgs = value; } }

        protected DynamicBufferManager MReceiveBuffer;
        public DynamicBufferManager ReceiveBuffer { get { return MReceiveBuffer; } set { MReceiveBuffer = value; } }

        protected bool MState;
        public bool State { get { return MState; } set { MState = value; } }

        protected AsyncSendBufferManager MSendBuffer;
        public AsyncSendBufferManager SendBuffer { get { return MSendBuffer; } set { MSendBuffer = value; } }

        protected AsyncSocketInvokeElement MAsyncSocketInvokeElement; //协议对象
        public AsyncSocketInvokeElement AsyncSocketInvokeElement { get { return MAsyncSocketInvokeElement; } set { MAsyncSocketInvokeElement = value; } }

        protected Socket MConnectSocket;
        public Socket ConnectSocket
        {
            get
            {
                return MConnectSocket;
            }
            set
            {
                MConnectSocket = value;
                if (MConnectSocket == null) //清理缓存
                {
                    MAsyncSocketInvokeElement?.Close();
                    MReceiveBuffer.Clear(MReceiveBuffer.DataCount);
                    MSendBuffer.ClearPacket();
                }
                MAsyncSocketInvokeElement = null;
                MReceiveEventArgs.AcceptSocket = MConnectSocket;
                MSendEventArgs.AcceptSocket = MConnectSocket;
            }
        }

        protected DateTime MActiveDateTime;
        public DateTime ActiveDateTime { get { return MActiveDateTime; } set { MActiveDateTime = value; } }


        protected DateTime MConnectDateTime;
        public DateTime ConnectDateTime { get { return MConnectDateTime; } set { MConnectDateTime = value; } }

        public AsyncSocketUserToken(int asyncReceiveBufferSize)
        {
            MState = false;
            MConnectSocket = null;
            MAsyncSocketInvokeElement = null;
            MReceiveEventArgs = new SocketAsyncEventArgs {UserToken = this};
            MAsyncReceiveBuffer = new byte[asyncReceiveBufferSize];
            MReceiveEventArgs.SetBuffer(MAsyncReceiveBuffer, 0, MAsyncReceiveBuffer.Length);
            MSendEventArgs = new SocketAsyncEventArgs {UserToken = this};
            MReceiveBuffer = new DynamicBufferManager(ProtocolConst.InitBufferSize);
            MSendBuffer = new AsyncSendBufferManager(ProtocolConst.InitBufferSize);
        }
    }
}
