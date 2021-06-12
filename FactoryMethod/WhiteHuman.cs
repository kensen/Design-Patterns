using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public class WhiteHuman : Human
    {
        public override void GetColor()
        {
           Console.WriteLine("白色人种的皮肤是白色的！");
        }
        public override void Talk()
        {
            Console.WriteLine("白种人会说话，一般是单字节。");
        }
    }
}
