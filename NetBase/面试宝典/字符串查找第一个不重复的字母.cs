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
        /// 字符串查找第一个不重复的字母
        /// </summary>
        public static void FindDontRepeatStr2(string text)
        {
            if (text.Length <= 0)
                throw new Exception();

            foreach (char item in text)
            {

                if (item == ' ')
                    continue;

                if (text.IndexOf(item,text.IndexOf(item) + 1) < 1)
                    Console.WriteLine(item);
            }

        }

        /// <summary>
        /// 字符串查找第一个不重复的字母
        /// </summary>
        public static void FindDontRepeatStr(string text)
        {

            int index = 0;
            //var arr = text.ToArray();
            while (text.Length > index)
            {
                char findChar = text[index];
                if (findChar == ' ')
                    continue;


                if (text.IndexOf(findChar, index+1 ) >= 1)
                {
                    text = text.Replace(findChar, '\0');
                }
                else
                {
                    Console.WriteLine(findChar);
                }

                index++;
            }



            //Console.WriteLine("没有找到！！");
        }


    }
}
