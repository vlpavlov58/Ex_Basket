using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Basket.Players
{
    class CheaterPlayer : PlayerBase
    {
        public override int Choose()
        {
            return 100;
        }
    }
}
