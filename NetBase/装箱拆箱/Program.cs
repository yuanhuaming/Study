using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
    
            //string b = "22";
            object c = 11;
            if (((int)c)==a)
            {
                Console.WriteLine("((int)c)==a");
            }
         
   
            if (Object.ReferenceEquals(c, a))
                Console.WriteLine("Object.ReferenceEquals(c,a)");


            Console.Read();

        }
    }
}
