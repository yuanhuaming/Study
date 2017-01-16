using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace 集合
{
  public   class example1
    {

      public static void test1()
      {
       Lists list = new Lists();
             foreach (var s in list)
            {
             
              Console.WriteLine(s.Name);
             
            }

        
      }
    }
}
