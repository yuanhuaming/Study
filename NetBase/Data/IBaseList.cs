using System.Collections;
using System.Collections.Generic;

namespace Common
{
    public interface IBaseList<out T> : IList, IEnumerable<T>
    {
         
    }

    public interface BaseList<out T> : IBaseList<T>
    {

    }
}
