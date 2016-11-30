using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Pattern.Iterator
{
    /// <summary>
    /// ���ϣ�ConcreteAggregate��
    /// </summary>
    public class Collection : ICollection, IEnumerable, IEnumerator
    {
        private List<MessageModel> list = new List<MessageModel>();

        /// <summary>
        /// ��������������
        /// </summary>
        /// <returns></returns>
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// �����ڵĶ�������
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="index">index</param>
        /// <returns></returns>
        public MessageModel this[int index]
        {
            get { return list[index]; }
            set { list.Add(value); }
        }


        #region IEnumerable ��Ա

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator ��Ա

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
