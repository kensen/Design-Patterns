using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class BlackMan:Human
    {
        public override void GetColor()
        {
            Console.WriteLine("黑色人种的皮肤是黑色的！");
        }

        public override void Talk()
        {
            Console.WriteLine("黑种人会说话，一般人听不懂。");
        }
    }
}
