using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 关键字使用和执行顺序;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            DoKeyword1();
            //DoKeyword2();

            Console.ReadKey();
        }

        /// <summary>
        /// const readonly
        /// </summary>
        private static void DoKeyword2()
        {
            Console.WriteLine("========初始化字段=================");
            Console.WriteLine(Keyword2.Name_const);
            Console.WriteLine(Keyword2.Name_static);
            Console.WriteLine(Keyword2.Name_static_readonly);

            Console.WriteLine("========初始化构造函数=================");
            Keyword2 kw = new Keyword2();
            Console.WriteLine(kw.Name_readonly);
            Console.WriteLine(Keyword2.Name_const);
            Console.WriteLine(Keyword2.Name_static);
            Console.WriteLine(Keyword2.Name_static_readonly);

            Console.WriteLine("========修改内容=================");
            //Keyword2.Name_const = Keyword2.Name_const+"_Edit";
            //Keyword2.Name_static_readonly = Keyword2.Name_static_readonly + "_Edit";
            //kw.Name_readonly = Keyword2.Name_readonly + "_Edit";   
            Keyword2.Name_static = Keyword2.Name_static + "_Edit";
            Console.WriteLine(Keyword2.Name_static);
        }

        private static void DoKeyword1()
        {
            KeywordA a = new KeywordA();
            a.Test();
            a.Test1();
            Console.WriteLine("=========================");
            KeywordB b = new KeywordB();
            b.Test();
            b.Test1();
            a = new KeywordB();
            a.Test();
            a.Test1();
            Console.WriteLine("=========================");
            KeywordC c = new KeywordC();
            c.Test();

            a = new KeywordC();
            a.Test();
            a.Test1();
            Console.WriteLine("=========================");

        }
    }
}
