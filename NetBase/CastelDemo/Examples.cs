using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CastelDemo
{
    public class Examples
    {
        public void ex1()
        {
            var container = new WindsorContainer();
            // 常规注册  默认的注册类型是Singleton也就是单例
            container.Register(Component.For<BaseService>());
            // 给接口注册一个默认实例
            container.Register(Component.For<IBaseService>().ImplementedBy<BaseService>().LifeStyle.Transient);

            //注册一个接口有多个实例,默认是注册第一个ServiceImpl的
            container.Register(
                 Component.For<IBaseService>().Named("BaseService").ImplementedBy<BaseService>(),
                 Component.For<IBaseService>().Named("DefualtService").ImplementedBy<DefualtService>()
            );


            //控制反转 得到实例
            var myService = container.Resolve<IBaseService>();
        }



    }

    //程序集进行注册
    public class WindsorControllerFactory
    {

         private IWindsorContainer container = new WindsorContainer();
        public WindsorControllerFactory(IWindsorContainer container)
        {
            this.container = container;

            // Assembly.GetExecutingAssembly()是获取当前运行的程序集
            var controllerTypes =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where typeof(IBaseService).IsAssignableFrom(t)
                select t;
            foreach (var t in controllerTypes)
                container.Register(Component.For(t).LifeStyle.Transient);
        }
    }
}
