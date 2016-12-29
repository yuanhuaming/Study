using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.AbstractFactory
{
    /// <summary>
    /// ����Messageʵ���ࣨAbstractProduct��
    /// </summary>
    public abstract class AbstractMessageModel
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public AbstractMessageModel()
        {

        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="msg">Message����</param>
        /// <param name="pt">Message����ʱ��</param>
        public AbstractMessageModel(string msg, DateTime pt)
        {
            this._message = msg;
            this._publishTime = pt;
        }

        private string _message;
        /// <summary>
        /// Message����
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private DateTime _publishTime;
        /// <summary>
        /// Message����ʱ��
        /// </summary>
        public DateTime PublishTime
        {
            get { return _publishTime; }
            set { _publishTime = value; }
        }

        /// <summary>
        /// UserId
        /// </summary>
        public abstract string UserId
        {
            get;
            set;
        }
    }
}