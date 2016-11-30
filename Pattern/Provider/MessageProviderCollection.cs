using System.Configuration.Provider;
using System;

namespace Pattern.Provider
{
    /// <summary>
    /// Message��Provider������
    /// </summary>
    public class MessageProviderCollection : ProviderCollection
    {
        /// <summary>
        /// �򼯺�������ṩ����
        /// </summary>
        /// <param name="provider">Ҫ��ӵ��ṩ����</param>
        public override void Add(ProviderBase provider)
        {
            if (provider == null)
                throw new ArgumentNullException("provider��������Ϊnull");

            if (!(provider is MessageProvider))
                throw new ArgumentException("provider�������ͱ�����MessageProvider.");

            base.Add(provider);
        }
    }
}
