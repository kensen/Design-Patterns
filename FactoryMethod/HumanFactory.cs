using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class HumanFactory<T> where T:Human ,new()
    {
        public Human CreateHuman()
        {
            return new T();
        }
    }
}
