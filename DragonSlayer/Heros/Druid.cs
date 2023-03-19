using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer.Heros
{
    public class Druid : HeroBase
    {
        public override string Name => "Druid";
        public Druid()
        {
            Strength = 3;
            Defense = 3;
            Range = 1;
            Level = 1;
        }

        public override bool ShouldAttackFirst(CharacterBase other)
        {
            return true;
        }
    }
}
