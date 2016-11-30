using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async和Await使异步编程Demo
{

    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {

            Paint();

            Console.Read();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }






        public static async void Paint()
        {
            Console.WriteLine("start");
             DoWork();
            Console.WriteLine("end");
        }

        public static async void DoWork()
        {
            Console.WriteLine("head");
            Console.WriteLine( await  RequestBody());
            Console.WriteLine("foot");
        }

        public static async Task<string> RequestBody()

        {

            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return "body";
            });
        }
    }
}
