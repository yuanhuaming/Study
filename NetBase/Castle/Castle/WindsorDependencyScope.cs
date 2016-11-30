using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Castle.Core.Logging;
using Castle.Windsor;

namespace Castle.Castle
{
    public class WindsorDependencyScope: IDependencyScope
    {
        private ILogger logger = NullLogger.Instance;

        public ILogger Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        private IWindsorContainer container;

        protected IWindsorContainer Container
        {
            get { return container; }
        }

        public WindsorDependencyScope(IWindsorContainer container)
        {
            this.container = container;
        }

        public void Dispose()
        {
            // ChildScope 销毁时把 Container 也销毁；
            if (container.Parent != null)
            {
                container.RemoveChildContainer(container);
            }
            container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            // 根据 GetService 的约定， 遇到未知类型不能抛出异常
            Logger.DebugFormat("GetService of type {0}", serviceType);
            object service = null;
            try
            { 
                service = container.Resolve(serviceType);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Can not resolve {0}", serviceType), ex);
            }
            return service;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            Logger.DebugFormat("Get All Service of type {0}", serviceType);
            // Windsor 的 ResolveAll 方法不会抛出异常， 所以可以直接用；
            return container.ResolveAll(serviceType).Cast<object>();
        }

    }

    public class WindsorDependencyResolver : WindsorDependencyScope,  System.Web.Mvc.IDependencyResolver
    { 
        public WindsorDependencyResolver(IWindsorContainer container) : base(container) { }

        public IDependencyScope BeginScope()
        {
            // 创建一个新的 WindsorContainer ， 并添加为 ChildContainer
            var childContainer = new WindsorContainer();
            Container.AddChildContainer(childContainer);
            // 返回新的 DepedencyScope
            return new WindsorDependencyScope(childContainer);
        }

    }
}