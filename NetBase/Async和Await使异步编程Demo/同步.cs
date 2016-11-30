﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async和Await使异步编程Demo
{
    public partial class 同步 : Form
    {
        public 同步()
        {
            InitializeComponent();

            txbMainThreadID.Text = "sdfsdfsdf";
            txbMainThreadID.Focus();
            txbMainThreadID.SelectionStart = txbMainThreadID.TextLength;
            
            //textBox1.SelectAll();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.btnClick.Enabled = false;

            long length = AccessWeb();
            this.btnClick.Enabled = true;
            // 这里可以做一些不依赖回复的操作
            OtherWork();

            this.richTextBox1.Text += String.Format("\n 回复的字节长度为:  {0}.\r\n", length);
            txbMainThreadID.Text = Thread.CurrentThread.ManagedThreadId.ToString();
        }

        private long AccessWeb()
        {
            MemoryStream content = new MemoryStream();

            // 对MSDN发起一个Web请求
            HttpWebRequest webRequest = WebRequest.Create("http://msdn.microsoft.com/zh-cn/") as HttpWebRequest;
            if (webRequest != null)
            {
                // 返回回复结果
                using (WebResponse response = webRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        responseStream.CopyTo(content);
                    }
                }
            }

            richTextBox1.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            return content.Length;
        }

        private void OtherWork()
        {
            this.richTextBox1.Text += "\r\n等待服务器回复中.................\n";
        }


    }
}
