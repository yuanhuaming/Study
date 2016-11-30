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
        static  void Main(string[] args)
        {
            test();
           Console.WriteLine(Foo(30));
            Console.ReadLine();
        }

        public static void test()
        {
            ClassB b = new  ClassB();
            b.Name = "aaaa";
            b.Sex = "1";
            ClassA a = b;
            a.Name = "bbbb";
            ClassB bb = (ClassB) a;
            Console.WriteLine($"name={bb.Name},sex={bb.Sex}");
        }



        public static int Foo(int i)
        {
            if (i <= 0)
                return 0;
            else if (i > 0 && i <= 2)
                return 1;
            else return Foo(i - 1) + Foo(i - 2);
        }
        public static ClassA GetClassA()
        {

            var b = new ClassB();
            //b.Name = "aaaa";
            return b;
        }

        public static List<ClassA> GetClassAList()
        {
            
            var b = new List<ClassB>();
            //b.Name = "aaaa";
            return b.Select(a => a as ClassA).ToList();
        }
    }


    [Serializable]
    public class ClassA
    {
        public string Name { get; set; }
    }
    [Serializable]
    public class ClassB:ClassA
    {
        public string Sex { get; set; }
    }

 
    
}
