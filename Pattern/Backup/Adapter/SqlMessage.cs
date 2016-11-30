using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Adapter
{
    /// <summary>
    /// 源（Adaptee）角色
    /// Sql方式操作Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL方式获取Message", DateTime.Now));

            return l;
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // 代码略
            return true;
        }
    }
}
