using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Observer
{
    /// <summary>
    /// ����Message�Ľӿڣ�Observer��
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        string Insert(MessageModel mm);
    }
}
