using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FactoryMethod
{
    /// <summary>
    /// XmlMessage工厂（ConcreteCreator）
    /// </summary>
    public class XmlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// 实现工厂方法，返回XmlMessage对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new XmlMessage();
        }
    }
}
