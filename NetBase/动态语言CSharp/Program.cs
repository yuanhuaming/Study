using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace 动态语言CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            demoDynamicObject();
            demoIDynamicMetaObjectProvider();
            demoExpandObject();
            demo1();
            demoPython();

            Console.Read();
        }


        public static void demo1()
        {
            dynamic dyn = 5;
            Console.WriteLine(dyn.GetType());
            dyn = "test string";
            Console.WriteLine(dyn.GetType());
            dynamic startIndex = 2;
            string substring = dyn.Substring(startIndex);
            Console.WriteLine(substring);
           
        }

        /// <summary>
        /// 调用python
        /// </summary>
        public static void demoPython()
        {
            // 引入动态类型之后
            // 可以在C#语言中与动态语言进行交互
            // 下面演示在C#中使用动态语言Python
            ScriptEngine engine = Python.CreateEngine();
            Console.Write("调用Python语言的print函数输出: ");
            // 调用Python语言的print函数来输出
            engine.Execute("print 'Hello world'");
        }

        /// <summary>
        /// 使用ExpandObject来实现动态的行为
        /// </summary>
        public static void demoExpandObject()
        {
            dynamic expand = new ExpandoObject();
            // 动态为expand类型绑定属性
            expand.Name = "Learning Hard";
            expand.Age = 24;

            // 动态为expand类型绑定方法
            expand.Addmethod = (Func<int, int>)(x => x + 1);
            // 访问expand类型的属性和方法
            Console.WriteLine("expand类型的姓名为：" + expand.Name + " 年龄为： " + expand.Age);
            Console.WriteLine("调用expand类型的动态绑定的方法：" + expand.Addmethod(5));
        }


        /// <summary>
        /// 使用DynamicObject来实现动态行为
        /// </summary>
        public static void demoDynamicObject()
        {
            dynamic dynamicobj = new ChildDynamicObject();
          
            dynamicobj.Name = "Learning Hard";
            dynamicobj.Age = "24";
          var result=  dynamicobj.CallMethod("hello");
            Console.WriteLine("外部调用"+ result);


        }


        /// <summary>
        /// 使用IDynamicMetaObjectProvider来实现动态行为
        /// </summary>
        public static void demoIDynamicMetaObjectProvider()
        {
            dynamic dynamicobj2 = new DynamicMetaObjectProviderImpl();
            dynamicobj2.CallMethod();
        }
    }
}
