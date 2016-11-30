using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace 并行编程
{
   public  class 并行聚合
    {

       public static int ParallelSum()
       {
           return Lists.GetUserInfos().AsParallel().Sum(a => a.Age);

       }
    }
}
