using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Basket.Players
{
    public class OrdinaryPlayer : PlayerBase
    {
        public override int Choose()
        {
            return 200;
        }
    }
}
