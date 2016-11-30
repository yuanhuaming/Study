using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面试宝典
{
   partial class Utils
    {
        /// <summary>
        /// 一列数的规则如下: 1、1、2、3、5、8、13、21、34...... 求第30位数是多少， 用递归算法实现。
        /// 斐波那契数列
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Fibonacci(int i)
        {
            if (i <= 0)
                return 0;
            else if (i > 0 && i <= 2)
                return 1;
            else return Fibonacci(i - 1) + Fibonacci(i - 2);
        }

        /// <summary>
        /// 用循环实现
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
       public static long Fibonacci2(int count)
       {

            List<long> list = new List<long>() { 0, 1 };

            for (var i = 2; i <= count; i++)
            {

                list.Add(list[i - 2] + list[i - 1]);

                Console.WriteLine(string.Format("Index:{0} Value:{1}", i, list[i]));

            }
            return list[count];
         
        }
    }
}
