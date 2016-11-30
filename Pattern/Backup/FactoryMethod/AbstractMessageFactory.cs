using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FactoryMethod
{
    /// <summary>
    /// ����Message������Creator��
    /// </summary>
    public abstract class AbstractMessageFactory
    {
        // An Operation

        /// <summary>
        /// ��������
        /// </summary>
        /// <returns>AbstractMessage</returns>
        public abstract AbstractMessage CreateMessage();
    }
}
