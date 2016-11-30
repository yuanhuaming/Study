using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.AbstractFactory
{
    /// <summary>
    /// ����Message������AbstractFactory��
    /// </summary>
    public abstract class AbstractMessageFactory
    {
        /// <summary>
        /// ����MessageModel����
        /// </summary>
        /// <returns></returns>
        public abstract AbstractMessageModel CreateMessageModel();

        /// <summary>
        /// ����Message����
        /// </summary>
        /// <returns></returns>
        public abstract AbstractMessage CreateMessage();
    }
}