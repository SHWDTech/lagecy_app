using System;
using System.Collections.Generic;

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
    }
}