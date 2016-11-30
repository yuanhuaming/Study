using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Builder
{
    /// <summary>
    /// ָ���ߣ�Director��
    /// </summary>
    public class Message
    {
        /// <summary>
        /// ���þ��彨���߽�ɫ�Դ�����Ʒ����
        /// </summary>
        /// <param name="messageBuilder">AbstractMessageBuilder</param>
        /// <param name="mm">Messageʵ�����</param>
        public void Construct(AbstractMessageBuilder messageBuilder, MessageModel mm)
        {
            messageBuilder.BuilderInsert(mm);
            messageBuilder.BuilderGet();
        }
    }
}
