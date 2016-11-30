using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class MyList
    {
        public MyList(int length)
        {
            this.m_items = new object[length];
        }

        private object[] m_items;

        public object this[int index]
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get
            {
                return this.m_items[index];
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            set
            {
                this.m_items[index] = value;
            }
        }
    }

    public class MyList<T>
    {
        public MyList(int length)
        {
            this.m_items = new T[length];
        }

        private T[] m_items;

        public T this[int index]
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get
            {
                return this.m_items[index];
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            set
            {
                this.m_items[index] = value;
            }
        }
    }
}
