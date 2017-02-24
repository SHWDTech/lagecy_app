using System.Collections.Generic;

namespace ESMonApp.AsyncSocketCore
{
    struct SendBufferPacket
    {
        public int Offset;
        public int Count;
    }

    //由于是异步发送，有可能接收到两个命令，写入了两次返回，发送需要等待上一次回调才发下一次的响应
    public class AsyncSendBufferManager
    {
        private readonly DynamicBufferManager _mDynamicBufferManager;
        public DynamicBufferManager DynamicBufferManager => _mDynamicBufferManager;
        private readonly List<SendBufferPacket> _mSendBufferList;
        private SendBufferPacket _mSendBufferPacket;

        public AsyncSendBufferManager(int bufferSize)
        {
            _mDynamicBufferManager = new DynamicBufferManager(bufferSize);
            _mSendBufferList = new List<SendBufferPacket>();
            _mSendBufferPacket.Offset = 0;
            _mSendBufferPacket.Count = 0;
        }

        public void StartPacket()
        {
            _mSendBufferPacket.Offset = _mDynamicBufferManager.DataCount;
            _mSendBufferPacket.Count = 0;
        }

        public void EndPacket()
        {
            _mSendBufferPacket.Count = _mDynamicBufferManager.DataCount - _mSendBufferPacket.Offset;
            _mSendBufferList.Add(_mSendBufferPacket);
        }

        public bool GetFirstPacket(ref int offset, ref int count)
        {
            if (_mSendBufferList.Count <= 0) 
                return false;
            offset = _mSendBufferList[0].Offset;
            count = _mSendBufferList[0].Count;
            return true;
        }

        public bool ClearFirstPacket()
        {
            if (_mSendBufferList.Count <= 0)
                return false;
            var count = _mSendBufferList[0].Count;
            _mDynamicBufferManager.Clear(count);
            _mSendBufferList.RemoveAt(0);
            return true;
        }

        public void ClearPacket()
        {
            _mSendBufferList.Clear();
            _mDynamicBufferManager.Clear(_mDynamicBufferManager.DataCount);
        }
    }
}
