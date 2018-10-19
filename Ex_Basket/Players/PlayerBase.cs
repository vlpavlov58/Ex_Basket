using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Basket.Players
{
    public abstract class PlayerBase
    {
        public string Name { get; set; }

        public PlayerType PlayerType { get; set; }

        public abstract int Choose();
    }
}
