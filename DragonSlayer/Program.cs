using System.Xml.Serialization;
using DragonSlayer.Constants;
using DragonSlayer.Dragons;
using DragonSlayer.Heros;

namespace DragonSlayer
{
    internal class Program
	{
		static void Main(string[] args)
		{
			var game = new Game();
			game.Run();
		}
	}
}