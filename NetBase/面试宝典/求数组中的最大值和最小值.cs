using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面试宝典
{
    public class 求数组中的最大值和最小值
    {


        public static void Do(int[] data)
        {
            int max = 0;
            int min = 0;
             
            if (data.Length < 2)
            {
                return;
            }

            if (data[0] > data[1])
            {
                max = data[0];
                min = data[1];
            }
            else
            {
                max = data[1];
                min = data[0];
            }
            
            for (int index = 2; index < data.Length; index++)
            {
                //if (data[index] > data[index + 1]&& index ==0)
                //{

                //    max = data[index];
                //    min = data[index + 1];
                //}
                 if (max <data[index]   )
                 {
                     max = data[index];
                    //cnt++;
                 }
                 else if (min > data[index])
                 {
                     min = data[index];
                    //cnt++;
                 }
               
            }

            Console.WriteLine($"min={min} ,max={max},数组长度={data.Length}");
        }

        public static void Do2(int[] data)
        {
            int max = 0;
            int min = 0;

            if (data.Length < 2)
            {
                return;
            }
            //if (data[0] > data[1])
            //{
            //    max = data[0];
            //    min = data[1];
            //}
            //else
            //{
            //    max = data[1];
            //    min = data[0];
            //}

            for (int index = 0; index < data.Length-1; index+=2)
            {
                if (data[index] - data[index + 1]>0)
                {
                    max = data[index];
                     
                }

                //if (data[index] > data[index + 1]&& index ==0)
                //{

                //    max = data[index];
                //    min = data[index + 1];
                //}
                if (max < data[index])
                {
                    max = data[index];
                    //cnt++;
                }
                else if (min > data[index])
                {
                    min = data[index];
                    //cnt++;
                }

            }

            Console.WriteLine($"min={min} ,max={max},数组长度={data.Length}");
        }


    }
}
