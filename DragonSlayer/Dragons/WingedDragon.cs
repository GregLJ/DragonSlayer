using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonSlayer.Constants;

namespace DragonSlayer.Dragons
{
    public class WingedDragon : DragonBase
    {
        public override string Name => "Winged Dragon";
        public WingedDragon()
        {
            Strength = 1;
            Defense = 7;
            Range = 2;
            Alignment = Alignment.Evil;
        }
    }
}
