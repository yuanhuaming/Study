using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 类型转换1
{
    class Program
    {


        static void Main(string[] args)
        {
            //foreach (var VARIABLE in Task)
            //{
            //    task
            //}
       
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.ReadKey();
        }

        private static string  contents="hello world!!!!   ";


        public static void SayHi(string name)
        {
            Console.WriteLine($"{contents} + + {name}");
        }
    }



}
