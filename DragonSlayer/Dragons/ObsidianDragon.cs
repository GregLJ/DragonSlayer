using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonSlayer.Constants;

namespace DragonSlayer.Dragons
{
    public class ObsidianDragon : DragonBase
    {
        public override string Name => "Obsidian Dragon";
        public ObsidianDragon()
        {
            Strength = 6;
            Defense = 2;
            Range = 3;
            Alignment = Alignment.Evil;
        }
    }
}
