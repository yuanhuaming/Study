using System;
using System.Collections.Specialized;
using System.Collections.Generic;

using System.Configuration.Provider;
using System.Configuration;

namespace Pattern.Provider
{
    /// <summary>
    /// Xmll方式操作Message
    /// </summary>
    public class XmlMessageProvider : MessageProvider
    {
        private string _connectionString;

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            // 代码略
            return true;
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("XML方式，连接字符串是" + this._connectionString, DateTime.Now));

            return l;
        }

        /// <summary>
        /// 初始化提供程序。
        /// </summary>
        /// <param name="name">该提供程序的友好名称。</param>
        /// <param name="config">名称/值对的集合，表示在配置中为该提供程序指定的、提供程序特定的属性。</param>
        public override void Initialize(string name, NameValueCollection config)
        {
            if (string.IsNullOrEmpty(name))
                name = "MessageProvider";

            if (null == config)
                throw new ArgumentException("config参数不能为null");

            if (string.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "XML操作Message");
            }

            base.Initialize(name, config);

            string temp = config["connectionStringName"];
            if (temp == null || temp.Length < 1)
                throw new ProviderException("connectionStringName属性缺少或为空");

            _connectionString = ConfigurationManager.ConnectionStrings[temp].ConnectionString;
            if (_connectionString == null || _connectionString.Length < 1)
            {
                throw new ProviderException("没找到'" + temp + "'所指的连接字符串，或所指连接字符串为空");
            }

            config.Remove("connectionStringName");
        }
    }
}
