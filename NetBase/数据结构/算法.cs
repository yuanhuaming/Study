using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构
{
   public static class S_算法
    {

       public static void 高斯算法(int n)
       {
           int sum = 0;
        

           if (n%2!=0)
           {
                // 高斯
                sum = (1 + n-1) * (n-1) / 2 +n;
            }
           else
           {
                // 高斯
                sum = (1 + n) * n / 2;
            }
 
            
           Console.WriteLine(sum);
       }

        /// <summary>
        /// 小兔子，每个月能生小兔子，小兔子2个月后能生第一胎
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
       public static int 斐波那契数列(int n)
       {
           if (n<3)
           {
               return n == 0 ? 0 : 1;
           }
           return 斐波那契数列(n - 2) + 斐波那契数列(n - 3);
       }

        /// <summary>
        /// S字符串中匹配T
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
       public static bool KMP普拉特模式匹配(this string s, string t)
        {
            int cnt = s.Length - t.Length;
            if (cnt<0)
                return false;
           
            for (int i = 0; i <= cnt; i++)
            {
                var s1 = s.Substring(i, t.Length);

                if (s1==t)
                    return true;
            }
          
            return false;
        }

       private static int RecursiveCallCnt =1;
        /// <summary>
        ///  
        /// </summary>
        /// <param name="range"></param>
        /// <param name="lr">左还是右
        /// 0：左
        /// 1：右
        /// -1：根
        /// </param>
        /// <param name="findKey"></param>
       public static void 二叉树算法(int range,int lr, int findKey)
       {
           int half = range/2;

            if (lr==-1)
            {
                if (half > findKey)
                {
                    二叉树算法(half,0, findKey);
                }
                else if (half == findKey)
                {
                    Console.WriteLine("递归几次结束。" + RecursiveCallCnt);
                }
                else if (half < findKey)
                {
                    二叉树算法(half, 1, findKey);
                }
            }


            RecursiveCallCnt++;

       }



    }
}
