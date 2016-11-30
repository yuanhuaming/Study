using System;
using System.Collections.Specialized;
using System.Collections.Generic;

using System.Configuration.Provider;
using System.Configuration;

namespace Pattern.Provider
{
    /// <summary>
    /// Xmll��ʽ����Message
    /// </summary>
    public class XmlMessageProvider : MessageProvider
    {
        private string _connectionString;

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            // ������
            return true;
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("XML��ʽ�������ַ�����" + this._connectionString, DateTime.Now));

            return l;
        }

        /// <summary>
        /// ��ʼ���ṩ����
        /// </summary>
        /// <param name="name">���ṩ������Ѻ����ơ�</param>
        /// <param name="config">����/ֵ�Եļ��ϣ���ʾ��������Ϊ���ṩ����ָ���ġ��ṩ�����ض������ԡ�</param>
        public override void Initialize(string name, NameValueCollection config)
        {
            if (string.IsNullOrEmpty(name))
                name = "MessageProvider";

            if (null == config)
                throw new ArgumentException("config��������Ϊnull");

            if (string.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "XML����Message");
            }

            base.Initialize(name, config);

            string temp = config["connectionStringName"];
            if (temp == null || temp.Length < 1)
                throw new ProviderException("connectionStringName����ȱ�ٻ�Ϊ��");

            _connectionString = ConfigurationManager.ConnectionStrings[temp].ConnectionString;
            if (_connectionString == null || _connectionString.Length < 1)
            {
                throw new ProviderException("û�ҵ�'" + temp + "'��ָ�������ַ���������ָ�����ַ���Ϊ��");
            }

            config.Remove("connectionStringName");
        }
    }
}
