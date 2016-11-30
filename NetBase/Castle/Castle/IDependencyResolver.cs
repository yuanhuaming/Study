using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Castle.Castle
{
    /// <summary>
    /// IDependencyResolver 接口继承自 IDependencyScope 并添加了一个 BeginScope 方法。 
    /// 每次请求都会创建新的 Controller ， 为了管理对象的生命周期，
    ///  IDependencyResolver 使用了作用域 (Scope) 的概念。
    /// </summary>
    public interface IDependencyResolver : IDependencyScope, IDisposable
    {
        IDependencyScope BeginScope();
    }

    public interface IDependencyScope : IDisposable
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}