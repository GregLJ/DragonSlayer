using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer
{
	public abstract class CharacterBase
	{
		public abstract string Name { get; } 
		public int Strength { get; set; }
		public int Defense { get; set; }
		public int Range { get; set; }
		public int HitPoints { get; set; }
		public bool isAlive { get; set; } = true;

		public void Attack(CharacterBase defender)
		{
			if (defender.Defense <= Strength)
			{
				defender.isAlive = false;
			}
			else
			{
				defender.HitPoints -= Strength;
			}
		}
	}
}
