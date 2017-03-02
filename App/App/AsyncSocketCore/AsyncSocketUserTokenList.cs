using System;
using System.Collections.Generic;
using ESMonApp.AsyncSocketProtocolCore;

namespace ESMonApp.AsyncSocketCore
{
    public class AsyncSocketUserTokenList : object
    {
        private readonly List<AsyncSocketUserToken> _mList;

        public AsyncSocketUserTokenList()
        {
            _mList = new List<AsyncSocketUserToken>();
        }

        public void Add(AsyncSocketUserToken userToken)
        {
            lock(_mList)
            {
                _mList.Add(userToken);
            }
        }

        public void Remove(AsyncSocketUserToken userToken)
        {
            lock (_mList)
            {
                _mList.Remove(userToken);
            }
        }

        public void CopyList(ref AsyncSocketUserToken[] array)
        {
            //if (array == null) throw new ArgumentNullException(nameof(array));
            lock (_mList)
            {
                array = new AsyncSocketUserToken[_mList.Count];
                _mList.CopyTo(array);
            }
        }

        public void AdjestTime()
        {
            lock (_mList)
            {
                foreach (var userToken in _mList)
                {
                    var buffer = new byte[64];
                    var bufferLen = 0;
                    var cmd = new TimeSyncCmd();

                    cmd.EncodeCmd(DateTime.Now);
                    cmd.EncodeFrame(ref buffer, ref bufferLen);

                    userToken.AsyncSocketInvokeElement.DoSendResult(buffer, 0, bufferLen);
                }
            }
        }
    }
}