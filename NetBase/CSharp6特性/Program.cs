using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6特性
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo3 user3=new UserInfo3();
            user3.SayHello(user3);
            user3.SayHelloNew(user3);


            GetObjectName();
             
            Console.ReadLine();

 
        }


        /// <summary>
        /// 获取参数/变量的名称
        /// 原先要用反射获取
        /// </summary>
        public static void GetObjectName()
        {
            Console.WriteLine( nameof(UserInfo3));
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExceptionFliters()
        {
            try
            {

            }
            catch (Exception ex)   
            {
                

                throw;
            }
        }

 
    }




    /// <summary>
    /// Struct的默认构造函数
    /// </summary>
    struct Complex1
    {
        public string Re { get; set; }  
        public int Im { get; set; }
     
    }
    /// <summary>
    /// 属性赋值
    /// 只读属性表达式
    /// </summary>
    public class UserInfo1
    {
        public string Name { get; set; } = "Tom";
        public int Age { get; set; } = 12;

        public int Height { get { return 168 + new Random().Next(1, 10); } }
        public int HeightNew => 168 + new Random().Next(1, 10);
    }

    /// <summary>
    /// 方法表达式
    /// </summary>
    public class UserInfo2
    {
        public string Name { get; set; } = "Tom";
        public int Age { get; set; } = 12;

        public void Introduce()
        {
            //C#6 字符串拼接方式，很方便吧！
            Console.WriteLine($"my name is {Name},{Age}.");
        }

        public void IntroduceNew() => Console.WriteLine($"my name is {Name},{Age}.");

    }

    /// <summary>
    ///  空引用检查 
    /// </summary>
    public class UserInfo3
    {
        public string Name { get; set; }  
        public int Age { get; set; } 

      
        public   void SayHello(UserInfo3 user)
        {
            if (user.Name==null)
                return;
            Console.WriteLine($"hi, {user.Name}");
        }
        //输出 hi,  
        public void SayHelloNew(UserInfo3 user)
        {
            Console.WriteLine($"hi, {user?.Name}");
        }
    }

 


}
