using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonSlayer.Constants;

namespace DragonSlayer.Dragons
{
    public class GoldenDragon : DragonBase
    {
        public override string Name => "Golden Dragon";
        public GoldenDragon()
        {
            Strength = 1;
            Defense = 1;
            Range = 1;
            Alignment = Alignment.Good;

        }
    }
}
