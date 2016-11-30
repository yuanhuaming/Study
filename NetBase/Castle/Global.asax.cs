using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Castle;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Owin;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace Castle
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            // 创建 WindsorContainer 新实例
            var container = new WindsorContainer();
            // 向 Container 注册 WindsorDependencyResolver ， 这样 WindsorDependencyResolver 自己
            // 也可以使用使用依赖项；
            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<IDependencyResolver>().ImplementedBy<WindsorDependencyResolver>()
            );

            // 通过配置文件注册其它类型
          
              var installer = Windsor.Installer.Configuration.FromXmlFile("windsor.config");
            container.Install(installer);
           
           //config.DependencyResolver.Resolve<IDependencyResolver>();
            // 向 OWIN 注册 WebAPI
            app.UseWebApi(config);
        }
    }
}
