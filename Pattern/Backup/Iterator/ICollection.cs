using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Iterator
{
    /// <summary>
    /// ���Ͻӿڣ�Aggregate��
    /// </summary>
    public interface ICollection
    {
        /// <summary>
        /// ��������������
        /// </summary>
        /// <returns></returns>
        IIterator CreateIterator();
    }
}
