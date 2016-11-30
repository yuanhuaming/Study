using System.Configuration;

namespace Pattern.Provider
{
    /// <summary>
    /// Message��Provider������
    /// </summary>
    public class MessageProviderConfigurationSection : ConfigurationSection
    {
        private readonly ConfigurationProperty _defaultProvider;
        private readonly ConfigurationProperty _providers;
        private ConfigurationPropertyCollection _properties;
        
        /// <summary>
        /// ���캯��
        /// </summary>
        public MessageProviderConfigurationSection()
        {
            _defaultProvider = new ConfigurationProperty("defaultProvider", typeof(string), null);
            _providers = new ConfigurationProperty("providers", typeof(ProviderSettingsCollection), null);
            _properties = new ConfigurationPropertyCollection();

            _properties.Add(_providers);
            _properties.Add(_defaultProvider);
        }

        /// <summary>
        /// Message��Ĭ�ϵ�Provider
        /// </summary>
        [ConfigurationProperty("defaultProvider")]
        public string DefaultProvider
        {
            get { return (string)base[_defaultProvider]; }
            set { base[_defaultProvider] = value; }
        }

        /// <summary>
        /// Message�����е�Provider����
        /// </summary>
        [ConfigurationProperty("providers", DefaultValue = "SqlMessageProvider")]
        [StringValidator(MinLength = 1)]
        public ProviderSettingsCollection Providers
        {
            get { return (ProviderSettingsCollection)base[_providers]; }
        }

        /// <summary>
        /// Message��Provider�����Լ���
        /// ���� System.Configuration.ConfigurationPropertyCollection ��һ����ʵ����
        /// </summary>
        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}
