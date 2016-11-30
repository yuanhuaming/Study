using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Pattern.Iterator
{
    /// <summary>
    /// 集合（ConcreteAggregate）
    /// </summary>
    public class Collection : ICollection, IEnumerable, IEnumerator
    {
        private List<MessageModel> list = new List<MessageModel>();

        /// <summary>
        /// 创建迭代器对象
        /// </summary>
        /// <returns></returns>
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// 集合内的对象总数
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index">index</param>
        /// <returns></returns>
        public MessageModel this[int index]
        {
            get { return list[index]; }
            set { list.Add(value); }
        }


        #region IEnumerable 成员

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator 成员

        public object Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
