using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer.Heros
{
    public class Warrior : HeroBase
    {
        public override string Name => "Warrior";
        public Warrior()
        {
            Strength = 4;
            Defense = 2;
            Range = 1;
            Level = 1;
        }
    }
}
