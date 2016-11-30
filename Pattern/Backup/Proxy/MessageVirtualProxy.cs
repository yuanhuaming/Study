using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Proxy
{
    public class MessageVirtualProxy : IMessage
    {
        private SqlMessage _sqlMessage;

        #region IMessage 成员

        public List<MessageModel> Get()
        {
            if (_sqlMessage==null)
            {
                _sqlMessage = new SqlMessage();
                _sqlMessage.Get();
            }
        }

        public bool Insert(MessageModel mm)
        {
            if (_sqlMessage == null)
            {
                _sqlMessage = new SqlMessage();
                _sqlMessage.Insert(mm);
            }
        }

        #endregion
    }
}
