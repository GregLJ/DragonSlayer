using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonSlayer.Constants;

namespace DragonSlayer.Dragons
{
    public class NetherDragon : DragonBase
    {
        public override string Name => "Nether Dragon";
        public NetherDragon()
        {
            Strength = 5;
            Defense = 4;
            Range = 1;
            Alignment = Alignment.Evil;
        }
    }
}
