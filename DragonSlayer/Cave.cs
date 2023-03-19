using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonSlayer.Dragons;

namespace DragonSlayer
{
    public class Cave
	{
		public string Name { get; set; }
		public DragonBase Dragon { get; set; }

		public Cave(string name, List<DragonBase> availableDragons)
		{
			Random random = new Random();

			Name = name;
			int index = random.Next(availableDragons.Count);
			Dragon = availableDragons[index];
			availableDragons.RemoveAt(index);
		}
	}
}
