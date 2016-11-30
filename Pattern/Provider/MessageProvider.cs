using System.Configuration.Provider;
using System.Collections.Generic;

namespace Pattern.Provider
{
    /// <summary>
    /// 操作Message抽象类
    /// </summary>
    public abstract class MessageProvider : ProviderBase
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel mm);

        /// <summary>
        /// 获得Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();
    }
}
