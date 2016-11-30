using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面试宝典
{

    /// <summary>
    /// 写出程序的输出结果
    /// </summary>
    public abstract class A
    {
        public A()
        {
            Console.WriteLine("A");
        }

        public virtual void Fun()
        {
            Console.WriteLine("A.Fun()");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public new void Fun()
        {
            Console.WriteLine("B.Fun()");
        }

    }





    public class AA
    {
        public virtual void Fun1(int i)
        {
            Console.WriteLine(i);
        }

        public void Fun2(AA a)
        {
            a.Fun1(1);
            Fun1(5);
        }
    }

    public class BB : AA
    {
        public override void Fun1(int i)
        {
            base.Fun1(i + 1);
        }

    }




    internal class AAA
    {
        public AAA()
        {
            PrintFields();
        }

        public virtual void PrintFields()
        {
        }
    }

    internal class BBB : AAA
    {
        private int x = 1;
        private int y;

        public BBB()
        {
            y = -1;
            PrintFields();
        }

        public override void PrintFields()
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }
    }
}
