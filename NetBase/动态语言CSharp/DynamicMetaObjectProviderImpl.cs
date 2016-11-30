using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace 动态语言CSharp
{
    /// <summary>
    /// 实现IDynamicMetaObjectProvider接口来实现动态行为.
    /// 
    /// 由于Dynamic类型在运行时来动态创建对象的，所以对该类型的每个成员的访问都会调用GetMetaObject方法来获得动态对象，
    /// 然后通过这个动态对象来进行调用，
    /// 所以实现IDynamicMetaObjectProvider接口，需要实现一个GetMetaObject方法来返回DynamicMetaObject对象
    /// </summary>
    public class DynamicMetaObjectProviderImpl: IDynamicMetaObjectProvider
    {
        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            Console.WriteLine("开始获得元数据......");
            return new Metadynamic(parameter, this);
        }
    }

    // 自定义Metadynamic类
    public class Metadynamic : DynamicMetaObject
    {
        internal Metadynamic(Expression expression, DynamicMetaObjectProviderImpl value)
            : base(expression, BindingRestrictions.Empty, value)
        {
        }
        // 重写响应成员调用方法
        public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
        {
            // 获得真正的对象
            DynamicMetaObjectProviderImpl target = (DynamicMetaObjectProviderImpl)base.Value;
            Expression self = Expression.Convert(base.Expression, typeof(DynamicMetaObjectProviderImpl));
            var restrictions = BindingRestrictions.GetInstanceRestriction(self, target);
            // 输出绑定方法名
            Console.WriteLine(binder.Name + " 方法被调用了");
            return new DynamicMetaObject(self, restrictions);
        }
    }
}
