using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
 
    /// <summary>
    /// 简单工厂方法变体泛型实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HumanFactory<T> where T:Human ,new()
    {
        public Human CreateHuman()
        {
            return new T();
        }
    }
}
