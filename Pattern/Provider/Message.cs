using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Configuration;

namespace Pattern.Provider
{
    /// <summary>
    /// ��¶���ͻ����õ�Message���ࣨContext��
    /// </summary>
    public class Message
    {
        private static bool m_isInitialized = false;
        private static MessageProviderCollection _providers = null;
        private static MessageProvider _provider = null;

        /// <summary>
        /// ��̬���캯������ʼ��
        /// </summary>
        static Message()
        {
            Initialize();
        }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public static bool Insert(MessageModel mm)
        {
            return _provider.Insert(mm);
        }

        /// <summary>
        /// ��ȡ��Ϣ
        /// </summary>
        /// <returns></returns>
        public static List<MessageModel> Get()
        {
            return _provider.Get();
        }

        private static void Initialize()
        {
            try
            {
                MessageProviderConfigurationSection messageConfig = null;

                if (!m_isInitialized)
                {

                    // �ҵ������ļ��С�MessageProvider���ڵ�
                    messageConfig = (MessageProviderConfigurationSection)ConfigurationManager.GetSection("MessageProvider");

                    if (messageConfig == null)
                        throw new ConfigurationErrorsException("�������ļ���û�ҵ���MessageProvider���ڵ�");

                    _providers = new MessageProviderCollection();

                    // ʹ��System.Web.Configuration.ProvidersHelper�����ÿ��Provider��Initialize()����
                    ProvidersHelper.InstantiateProviders(messageConfig.Providers, _providers, typeof(MessageProvider));

                    // ���õ�ProviderΪ������Ĭ�ϵ�Provider
                    _provider = _providers[messageConfig.DefaultProvider] as MessageProvider;

                    m_isInitialized = true;

                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new Exception(msg);
            }
        }

        private static MessageProvider Provider
        {
            get
            {
                return _provider;
            }
        }

        private static MessageProviderCollection Providers
        {
            get
            {
                return _providers;
            }
        }
    }
}
