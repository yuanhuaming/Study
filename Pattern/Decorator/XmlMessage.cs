using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Decorator
{
    /// <summary>
    /// Xml��ʽ����Message��ConcreteComponent��
    /// </summary>
    public class XmlMessage : AbstractMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("XML��ʽ��ȡMessage", DateTime.Now));

            return l;
        }

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
    }
}