using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.ChainOfResponsibility
{
    /// <summary>
    /// Sql��ʽ����Message
    /// </summary>
    public class SqlMessage
    {
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
