using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class YellowHuman:Human
    {
        public override void GetColor()
        {
            Console.WriteLine("黄色人种的皮肤是黄色的！");
        }

        public override void Talk()
        {
            Console.WriteLine("黄种人会说话，一般说的都是双字节。");
        }
    }
}
