using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace Pattern.Observer
{
    /// <summary>
    /// Messageʵ����
    /// </summary>
    public class MessageModel : INotifyPropertyChanged
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="msg">Message����</param>
        /// <param name="pt">Message����ʱ��</param>
        public MessageModel(string msg, DateTime pt)
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

        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
