using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关键字使用和执行顺序
{
    public class Keyword2
    {

        public static string Name_static = "Name_static";

        public readonly string Name_readonly = "Name_readonly";

        public const string Name_const = "Name_const";

        public static readonly string Name_static_readonly = "Name_static_readonly";
        


        public Keyword2(string text="Init")
        {
            Name_static = "Name_static_" + text;
            Name_readonly = "Name_readonly_" + text;
            //Name_const = "Name_const" + text;
            //Name_static_readonly = "Name_static_readonly" + text;
    
        }

       
    }
}
