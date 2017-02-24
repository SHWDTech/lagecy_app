using System;
using System.Collections.Generic;
using System.Threading;

namespace ESMonApp
{
    /// <summary>
    /// 队列类（使用循环数组）(加上线程安全)
    /// </summary>
    /// <typeparam name="T">队列中元素的类型</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// 循环数组，初始
        /// </summary>
        private T[] _ary;
        public Queue(int size) 
        {
            _ary = new T[size]; 
        }
        
        /// <summary>
        /// 通知的状态机
        /// </summary>
        private readonly AutoResetEvent _notice = new AutoResetEvent(true);

        
        /// <summary>
        /// 队头
        /// </summary>
        private int _front;
        /// <summary>
        /// 队尾
        /// </summary>
        private int _rear;
        /// <summary>
        /// 队大小
        /// </summary>
        private int _size;
        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="t">入队元素</param>
        public void Enqueue(T t)
        {
            Lock();
            //如果队列大小等于数组长度，那么数组大小加倍
            if (_size == _ary.Length)
            {
                DoubleSize();
            }
            _ary[_rear] = t;
            //队尾前移
            _rear++;
            //这一句是循环数组的关键：
            //如果rear超过数组下标了，
            //那么将从头开始使用数组。
            _rear %= _ary.Length;
            //大小加一
            _size++;
            UnLock();
        }
        /// <summary>
        /// 出队
        /// </summary>
        /// <returns>出队元素</returns>
        public T Dequeue()
        {
            Lock();
            //如果大小为零，那么队列已经空了
            if (_size == 0)
            {
                UnLock();
                throw new Exception("队列已经空了");
            }
            var t = _ary[_front];
            //队头前移
            _front++;
            //这一句是循环数组的关键：
            //如果front超过数组下标了，
            //那么将从头开始使用数组。
            _front %= _ary.Length;
            //大小减一
            _size--;
            UnLock();
            return t;
        }
        /// <summary>
        /// 从队头提取一个元素（不删除）
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            Lock();
            //如果大小为零，那么队列已经空了
            if (_size == 0)
            {
                UnLock();
                throw new Exception("队列已经空了");
            }
            var t = _ary[_front];
            UnLock();
            return t;
        }
        /// <summary>
        /// 队大小
        /// </summary>
        public int Count
        {
            get
            {
                Lock();
                var result = _size;
                UnLock();
                return result;
            }
        }
        /// <summary>
        /// 清除队中的元素
        /// </summary>
        public void Clear()
        {
            Lock();
            _size = 0;
            _front = 0;
            _rear = 0;
            _ary = new T[_ary.Length];
            UnLock();
        }
        /// <summary>
        /// 数组大小加倍
        /// </summary>
        private void DoubleSize()
        {
            //临时数组
            var temp = new T[_ary.Length];
            //将原始数组的内容拷贝到临时数组
            Array.Copy(_ary, temp, _ary.Length);
            //原始数组大小加倍
            _ary = new T[_ary.Length * 2];
            //将临时数组的内容拷贝到新数组中
            for (var i = 0; i < _size; i++)
            {
                _ary[i] = temp[_front];
                _front++;
                _front %= temp.Length;
            }
            _front = 0;
            _rear = _size;
        }

        /// <summary>
        /// 拷贝
        /// </summary>
        public List<T> CopyList()
        {
            var list = new List<T>();

            foreach (var item in _ary)
            {
                list.Add(item);
            }
            
            return list;
        }
        
        /// <summary>
        /// 锁定
        /// </summary>
        private void Lock()
        {
            _notice.WaitOne();
        }
        /// <summary>
        /// 解锁
        /// </summary>
        private void UnLock()
        {
            _notice.Set();
        }
    }
}
