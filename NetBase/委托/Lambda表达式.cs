using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace 委托
{
   public  class Lambda表达式
    {
        /// <summary>
        /// Lambda 表达式使用演示
        /// </summary>
        public static void  UseLambda()
       {
            // Lambda表达式的演变过程
            // 下面是C# 1中创建委托实例的代码
            Func<string, int> delegatetest1 = new Func<string, int>(Callbackmethod);

            //                                  ↓
            // C# 2中用匿名方法来创建委托实例，此时就不需要额外定义回调方法Callbackmethod
            Func<string, int> delegatetest2 = delegate (string text)
            {
                return text.Length;
            };

            //                                  ↓
            // C# 3中使用Lambda表达式来创建委托实例
            Func<string, int> delegatetest3 = (string text) => text.Length;

            //                                  ↓
            // 可以省略参数类型string,把上面代码再简化为：
            Func<string, int> delegatetest4 = (text) => text.Length;

            //                                  ↓
            // 如果Lambda表达式只需一个参数，并且那个参数可以隐式指定类型时，
            // 此时可以把圆括号也省略,简化为：
            Func<string, int> delegatetest = text => text.Length;

            // 调用委托
            Console.WriteLine("使用Lambda表达式返回字符串的长度为： " + delegatetest("learning hard"));
            Console.WriteLine("使用Lambda表达式返回字符串的长度为： " + delegatetest1("learning hard"));
            Console.Read();
        }

       /// <summary>
       /// Lambda表达式来记录事件
       /// </summary>
       public static void UseLambdaForEvent()
       {
            // 新建一个button实例
            Button button1 = new Button() { Text = "点击我" };

            // C# 2中使用匿名方法来订阅事件
            //button1.Click+=delegate (object sender,EventArgs e)
            //{
            //    ReportEvent("Click事件", sender, e);
            //};
            //button1.KeyPress += delegate (object sender, KeyPressEventArgs e)
            //{
            //    ReportEvent("KeyPress事件，即键盘按下事件", sender, e);
            //};

            // C# 3Lambda表达式方式来订阅事件
            // 与上面使用匿名方法来订阅事件是不是看出简单了很多，并且也直观了
            button1.Click += (sender, e) => ReportEvent("click", sender, e);
            button1.KeyPress += (sender, e) => ReportEvent("KeyPress事件，即键盘按下事件", sender, e);

            // C# 3之前初始化对象时使用下面代码
            //Form form = new Form();
            //form.Name = "在控制台中创建的窗体";
            //form.AutoSize = true;
            //form.Controls.Add(button1);

            // C# 3中使用对象初始化器
            // 与上面代码的比较中，也可以看出使用对象初始化之后代码简化了很多
            Form form = new Form { Name = "在控制台中创建的窗体", AutoSize = true, Controls = { button1 } };

            // 运行窗体
            Application.Run(form);
        }

        /// <summary>
        /// 使用表达式树
        /// </summary>
       public static void UseLambdaTree()
       {
            #region 将Lambda表达式转换为表达式树演示
            // 将Lambda表达式转换为Express<T>的表达式树
            // 此时express不是可执行的代码，它现在是一个表达式树的数据结构
            Console.WriteLine("将Lambda表达式转化为表达式树的演示：");
            Expression<Func<int, int, int>> expression = (a, b) =>     a + b  ;
          
            // 获得表达式树的参数
            Console.WriteLine("参数1： {0},参数2：{1}", expression.Parameters[0], expression.Parameters[1]);

            // 既然叫做树，那肯定有左右节点
            // 获取表达式树的主体部分
            BinaryExpression body = (BinaryExpression)expression.Body;

            // 左节点,每个节点本身就是一个表达式对象
            ParameterExpression left = (ParameterExpression)body.Left;

            // 右节点
            ParameterExpression right = (ParameterExpression)body.Right;

            Console.WriteLine("表达式主体为：");
            Console.WriteLine(expression.Body);
            Console.WriteLine("表达式树左节点为：{0}{4} 节点类型为：{1}{4}{4} 表达式右节点为：{2}{4} 节点类型为：{3}{4}",
                left.Name, left.NodeType, right.Name, right.NodeType, Environment.NewLine);
            Console.Read();
            #endregion 

            #region 把表达式树转化回可执行代码

            // Compile方法生成Lambda表达式的委托
            Console.WriteLine("按下Enter键进入将表达式树转换为Lambda表达式的委托演示：");
            int result = expression.Compile()(2, 3);
            Console.WriteLine("调用Lambda表达式委托结果为：" + result);
            Console.ReadKey();
            #endregion
        }

        // 记录事件的回调方法
        private static void ReportEvent(string title, object sender, EventArgs e)
        {
            Console.WriteLine("发生的事件为：{0}", title);
            Console.WriteLine("发生事件的对象为：{0}", sender);
            Console.WriteLine("发生事件参数为： {0}", e.GetType());
            Console.WriteLine();
            Console.WriteLine();
        }



        /// <summary>
        /// 回调方法
        /// 如果使用了Lambda表达式和匿名函数，此方法就不需要额外定义
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static int Callbackmethod(string text)
        {
            return text.Length;
        }
    }
}
