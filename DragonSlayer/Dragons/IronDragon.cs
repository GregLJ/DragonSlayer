using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonSlayer.Constants;

namespace DragonSlayer.Dragons
{
    public class IronDragon : DragonBase
    {
        public override string Name => "Iron Dragon";
        public IronDragon()
        {
            Strength = 5;
            Defense = 6;
            Range = 3;
            Alignment = Alignment.Evil;
        }
    }
}
