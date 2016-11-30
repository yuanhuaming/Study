using System.Configuration.Provider;
using System;

namespace Pattern.Provider
{
    /// <summary>
    /// Message的Provider集合类
    /// </summary>
    public class MessageProviderCollection : ProviderCollection
    {
        /// <summary>
        /// 向集合中添加提供程序。
        /// </summary>
        /// <param name="provider">要添加的提供程序。</param>
        public override void Add(ProviderBase provider)
        {
            if (provider == null)
                throw new ArgumentNullException("provider参数不能为null");

            if (!(provider is MessageProvider))
                throw new ArgumentException("provider参数类型必须是MessageProvider.");

            base.Add(provider);
        }
    }
}
