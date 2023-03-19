using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer.Heros
{
    public class Mage : HeroBase
    {
        public override string Name => "Mage";
        public Mage()
        {
            Strength = 3;
            Defense = 2;
            Range = 3;
            Level = 1;
        }
    }
}
