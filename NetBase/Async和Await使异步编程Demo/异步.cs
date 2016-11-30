using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async和Await使异步编程Demo
{
    public partial class 异步 : Form
    {
        /// <summary>
        /// APM 异步编程模型
        /// </summary>
        public 异步()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            btnClick.Enabled = false;
            //AsyncMethodCaller caller = new AsyncMethodCaller(TestMethod);
            //IAsyncResult result = caller.BeginInvoke(GetResult, null);

            //// 捕捉调用线程的同步上下文派生对象
            //sc= SynchronizationContext.Current;
        }



        #region 使用APM实现异步编程
        // 同步方法
        private string TestMethod()
        {
            // 模拟做一些耗时的操作
            // 实际项目中可能是读取一个大文件或者从远程服务器中获取数据等。
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
            }

            return "点击我按钮事件完成";
        }

        // 回调方法
        private void GetResult(IAsyncResult result)
        {
            //AsyncMethodCaller caller = (AsyncMethodCaller)((AsyncResult)result).AsyncDelegate;
            //// 调用EndInvoke去等待异步调用完成并且获得返回值
            //// 如果异步调用尚未完成，则 EndInvoke 会一直阻止调用线程，直到异步调用完成
            //string resultvalue = caller.EndInvoke(result);
            ////sc.Post(ShowState,resultvalue);
            //richTextBox1.Invoke(showStateCallback, resultvalue);
        }

        // 显示结果到richTextBox
        private void ShowState(object result)
        {
            richTextBox1.Text = result.ToString();
            btnClick.Enabled = true;
        }

        // 显示结果到richTextBox
        //private void ShowState(string result)
        //{
        //    richTextBox1.Text = result;
        //    btnClick.Enabled = true;
        //}
        #endregion
    }
}
