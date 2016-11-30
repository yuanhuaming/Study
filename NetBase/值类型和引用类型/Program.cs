using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型输出开始=================");
            People p = new People();
            p.Name = "tom";
            p.Age = 18;
            p.Write();
            People pp = p;
            pp.Write();
            Console.WriteLine("pp改变一下值=================");
            pp.Name = "jack";
            pp.Age = 20;
            pp.Write();
            p.Write();
            Console.WriteLine("值类型输出结束=================");

            Console.WriteLine("引用类型输出开始=================");
            PeopleClass pc=new PeopleClass();
            pc.Name = "tom";
            pc.Age = 18;
            pc.Write();
            PeopleClass pcref = pc;
            pcref.Write();
            Console.WriteLine("pcref改变一下值=================");
            pcref.Name = "jack";
            pcref.Age = 20;
            pcref.Write();
            pc.Write();
            Console.WriteLine("引用类型输出结束=================");
            Console.ReadLine();
            
        }
    }


    /// <summary>
    /// 结构体
    /// </summary>
    public struct People
    {
        public  string Name { get; set; }
     
        public  int Age { get; set; }
        
        public void Write(Action action=null)
        {
            
            Console.WriteLine($"值类型 Name={Name} ,Age={Age}");
        }
    }

    /// <summary>
    /// 引用类
    /// </summary>
    public class PeopleClass
    {
        public string Name { get; set; }
       
        public int Age { get; set; }

        public void Write()
        {
           
            Console.WriteLine($"引用类型 Name={Name} ,Age={Age}");
        }
    }
}
