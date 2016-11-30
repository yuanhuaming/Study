using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IBaseList<out T> : IList, IEnumerable<T>
    {
         
    }

    public interface BaseList<out T> : IBaseList<T>
    {

    }
}
