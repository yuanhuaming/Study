using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关键字使用和执行顺序
{
    /// <summary>
    /// 关键字
    /// </summary>
    public class KeywordA
    {

        public KeywordA()
        {
            Name = "apple";
            Console.WriteLine("apple");
        }
        public string Name { get; set; } 

        public virtual void Test()
        {
            Console.WriteLine("KeywordA.Test()" + Name);
        }

        public   void Test1()
        {
            Console.WriteLine("KeywordA.Test1()" + Name);
        }
    }


    public class KeywordB : KeywordA
    {
        public KeywordB()
        {
            Name = "button";
            Console.WriteLine("button");
        }
         public new  string Name { get; set; } 
        public new  void Test()
        {
            Console.WriteLine("KeywordB.Test()" + Name);
            //base.Test();
        }

        public new void Test1()
        {
            Console.WriteLine("KeywordB.Test1()" + Name);
            //base.Test1();
        }
    }

    public class KeywordC : KeywordA
    {
        public KeywordC()
        {
            Name = "city";
            Console.WriteLine("city");
        }
    
        public override void Test()
        {
            Console.WriteLine("KeywordC.Test()"+Name);
            //base.Test();
        }
    }
}
