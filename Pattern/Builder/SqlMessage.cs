using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Builder
{
    /// <summary>
    /// Sql��ʽ����Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL��ʽ��ȡMessage", DateTime.Now));

            return l;
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // ������
            return true;
        }
    }
}