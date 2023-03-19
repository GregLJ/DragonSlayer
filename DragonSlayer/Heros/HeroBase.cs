using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DragonSlayer.Heros
{
    public abstract class HeroBase : CharacterBase
    {
        public int Level { get; set; }

        public static HeroBase Build(int selection)
        {
            switch (selection)
            {
                case 1:
                    return new Warrior();
                case 2:
                    return new Mage();
                case 3:
                    return new Druid();
                default:
                    return null;
            }
        }

        public virtual bool ShouldAttackFirst(CharacterBase other)
        {
            if (other.Range < Range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LevelUp()
        {
            Level++;
            Strength++;
            Defense++;
            Range++;
        }
    }
}
