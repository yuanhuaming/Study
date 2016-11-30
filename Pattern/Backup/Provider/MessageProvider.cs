using System.Configuration.Provider;
using System.Collections.Generic;

namespace Pattern.Provider
{
    /// <summary>
    /// ����Message������
    /// </summary>
    public abstract class MessageProvider : ProviderBase
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel mm);

        /// <summary>
        /// ���Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();
    }
}
