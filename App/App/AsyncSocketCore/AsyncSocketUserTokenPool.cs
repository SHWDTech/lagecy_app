using System;
using System.Collections.Generic;

namespace ESMonApp.AsyncSocketCore
{
    public class AsyncSocketUserTokenPool
    {
        private readonly Stack<AsyncSocketUserToken> _mPool;

        public AsyncSocketUserTokenPool(int capacity)
        {
            _mPool = new Stack<AsyncSocketUserToken>(capacity);
        }

        public void Push(AsyncSocketUserToken item)
        {
            if (item == null)
            {
                throw new ArgumentException("Items added to a AsyncSocketUserToken cannot be null");
            }
            lock (_mPool)
            {
                _mPool.Push(item);
            }
        }

        public AsyncSocketUserToken Pop()
        {
            lock (_mPool)
            {
                return _mPool.Pop();
            }
        }

        public int Count => _mPool.Count;
    }
}
