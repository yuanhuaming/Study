using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代码片段
{
    /// <summary>
    ///  CSharp6新语法
    /// </summary>
    class CSharp6
    {

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
    /// 方法表达式
    /// </summary>
    public class UserInfo2
    {
        public string Name { get; set; } = "Tom";
        public int Age { get; set; } = 12;


        public int Height { get { return 168 + new Random().Next(1, 10); } }
        public int HeightNew => 168 + new Random().Next(1, 10);

        public void Introduce()
        {
            //C#6 字符串拼接方式，很方便吧！
            Console.WriteLine($"my name is {Name},{Age}.");
        }

        public void IntroduceNew() => Console.WriteLine($"my name is {Name},{Age}.");



        #region 空引用检查
        public void SayHello(UserInfo2 user)
        {
            if (user.Name == null)
                return;
            Console.WriteLine($"hi, {user.Name}");
        }
        //输出 hi,  
        public void SayHelloNew(UserInfo2 user)
        {
            Console.WriteLine($"hi, {user?.Name}");
        }
        #endregion


        /// <summary>
        /// 获取参数/变量的名称
        /// 原先要用反射获取
        /// </summary>
        public static void GetObjectName()
        {
            Console.WriteLine(nameof(UserInfo2));
        }
    }

 



}
