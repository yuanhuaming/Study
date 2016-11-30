using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Observer
{
    /// <summary>
    /// Xml��ʽ����Message��ConcreteObserver��
    /// </summary>
    public class XmlMessage : IMessage
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public string Insert(MessageModel mm)
        {
            return "xml��ʽ��" + mm.Message + " " + mm.PublishTime.ToString();
        } 
    }
}
