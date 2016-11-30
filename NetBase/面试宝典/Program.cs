using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面试宝典
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddUp(new int[] { 1, 2, 3, 4 });
            //求数组中的最大值和最小值.Do(new int[] { 11, 4, 7, 9, 3 ,11,5,88,43,22,46,64,43});

            //Suanfa();
            Output();
            Utils.FindDontRepeatStr("caabcdegdjsidfj;lbasdkfa;sk!");
            Utils.FindDontRepeatStr2("abbd");


            Console.ReadKey();
        }

        /// <summary>
        /// 累加算法
        /// </summary>
        private static void AddUp(int[] nums)
        {
            if (nums == null||nums.Length<=0)
                throw new NullReferenceException("数组为空");

            if (nums.Length<2)
            {
                Console.WriteLine(nums[0]);
            }
            Console.WriteLine((nums[nums.Length-1]+nums[0])* nums.Length/2);
        }


        private static void Suanfa()
        {
            //一列数的规则如下: 1、1、2、3、5、8、13、21、34...... 求第30位数是多少， 用递归算法实现。
            Console.WriteLine(Utils.Fibonacci(30));
            Console.WriteLine(Utils.Fibonacci2(30));

        }

        /// <summary>
        /// 写出程序的输出结果
        /// </summary>
        private static void Output()
        {
            ///父类先初始化在初始化子类
            /// 静态字段 ->普通public字段 -> 构造函数 
            A a = new B();
            a.Fun();
            B b = new B();
            b.Fun();
            //========================================
            BB bb = new BB();
            AA aa = new AA();
            aa.Fun2(bb);
            bb.Fun2(aa);
            //===========================================
            BBB bbb= new BBB();
            AAA aaa = new BBB();

        }

    }
}
