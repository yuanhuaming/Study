using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Proxy
{
    /// <summary>
    /// ��Message�����Ľӿ�
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        List<MessageModel> Get();

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        bool Insert(MessageModel mm);
    }
}
