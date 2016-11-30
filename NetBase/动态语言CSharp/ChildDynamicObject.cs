using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动态语言CSharp
{
  public   class ChildDynamicObject: DynamicObject
    {
        // 重写方法，
        // TryXXX方法表示对对象的动态调用
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + " 方法正在被调用");
            if (binder.Name == "CallMethod")
            {
                CallMethod(args[0]);
            }
            result = "ok";
            return true;
        }

      private void CallMethod(object item)
      {
            Console.WriteLine("姓名："+ item.ToString());
       }


      //public override bool TryGetMember(GetMemberBinder binder, out object result)
      //{
      //      result = 0;
      //      Console.WriteLine(binder.Name + " 属性被设置，" + "设置的值为： " + result);
      //      return true;
      //  }

      public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            Console.WriteLine(binder.Name + " 属性被设置，" + "设置的值为： " + value);
            return true;
        }
    }
}
