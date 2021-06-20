using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class YellowHumanFactoryFactory : AbstractFactory
    {
        public override Human CreateHuman()
        {
            return  new YellowHuman();
        }
    }
}
