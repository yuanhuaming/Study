using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.AbstractFactory
{
    /// <summary>
    /// ����Message�����ࣨAbstractProduct��
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="amm">AbstractMessageModel</param>
        /// <returns></returns>
        public abstract string Insert(AbstractMessageModel amm);
    }
}
