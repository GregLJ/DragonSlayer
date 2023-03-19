using DragonSlayer.Constants;
using DragonSlayer.Dragons;
using DragonSlayer.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer
{
	public class Game
	{
		private HeroBase hero;
		private Dictionary<int,Cave> caves;
		private bool gameOver = false;

		public void Run()
		{

			hero = CharacterSelection();
			caves = CaveInitialization();

			while (!gameOver)
			{
				Console.WriteLine("\nWhich Cave would you like to investigate?");
				foreach (var cave in caves)
				{
					Console.WriteLine($"{cave.Key}.){cave.Value.Name}");
				}

				int caveChoice = 0;
				bool validCaveChoice;

				Console.Write("Enter your choice: ");
				caveChoice = int.Parse(Console.ReadLine());

				if (caveChoice < 1 || caveChoice > 5 || !caves.ContainsKey(caveChoice))
				{
					Console.WriteLine("Invalid cave choice. Try Again.");
					continue;
				}

				Cave currentCave = caves[caveChoice];

			

				Console.WriteLine($"\nYou investigate the {currentCave.Name} and encounter a {currentCave.Dragon.Name}!");

				if (currentCave.Dragon.Alignment == Alignment.Good)
				{
					hero.Strength += currentCave.Dragon.Strength;
					hero.Defense += currentCave.Dragon.Defense;
					hero.Range += currentCave.Dragon.Range;
					Console.WriteLine($"You have met a {currentCave.Dragon.Name}, increase all stats by {currentCave.Dragon.Strength}");
					Console.WriteLine($"Updated stats: Strength[{hero.Strength}], Defense[{hero.Defense}], Range[{hero.Range}]");
					caves.Remove(caveChoice);
				}
				else
				{
					CharacterBase attacker = hero.ShouldAttackFirst(currentCave.Dragon) ? hero : currentCave.Dragon;
					CharacterBase defender = hero.ShouldAttackFirst(currentCave.Dragon) ? currentCave.Dragon : hero;
					bool isRunning = false;

					//Battle Loop
					while (!isRunning && attacker.isAlive && defender.isAlive)
					{
						Console.WriteLine($"{attacker.Name} is attacking {defender.Name}");
						attacker.Attack(defender);
						Console.WriteLine($"Attacker Strength: {attacker.Strength}, Defender Hit Points: {defender.Defense}");
						CharacterBase swap = attacker;

						attacker = defender;
						defender = swap;
						if (attacker.isAlive && defender.isAlive)
						{
							isRunning = true;
						}
					}
					if (isRunning)
					{
						Console.WriteLine("Hero has retreated to heal.");
						hero.HitPoints = hero.Defense;
					}
					else if (hero.isAlive)
					{
						hero.HitPoints = hero.Defense;
						Console.WriteLine($"{hero.Name} has triumphed!");
						hero.LevelUp();
						caves.Remove(caveChoice);
						if (caves.Count == 0)
						{
							Console.WriteLine("\nYou have vanquished this world of all the evil dragons!");
							PromptUserPlayAgain();
						}
					}
					else
					{
						Console.WriteLine($"{hero.Name} has met their demise! Game Over.");
						PromptUserPlayAgain();
					}
				}
			}
		}

		private void PromptUserPlayAgain()
		{
			Console.WriteLine("Would you like to play again, [y]es or [n]o?");
			var playAgain = Console.ReadLine();
			if (playAgain.ToLower().StartsWith("n"))
			{
				gameOver = true;
			}
			else
			{
				hero = CharacterSelection();
				caves = CaveInitialization();
			}
		}

		private Dictionary<int, Cave> CaveInitialization()
		{
			List<DragonBase> availableDragons = new()
			{
				new IronDragon(),
				new WingedDragon(),
				new NetherDragon(),
				new ObsidianDragon(),
				new GoldenDragon()
			};

			Dictionary<int, Cave> caves = new();

			caves.Add(1, new Cave("North Cave", availableDragons));
			caves.Add(2, new Cave("Eastern Cave", availableDragons));
			caves.Add(3, new Cave("SouthWest Cave", availableDragons));
			caves.Add(4, new Cave("SouthEast Cave", availableDragons));
			caves.Add(5, new Cave("Western Cave", availableDragons));
			return caves;
		}

		private HeroBase CharacterSelection()
		{
			Console.WriteLine("Welcome to Dragon Slayer!\nYour job is to investigate all of the large caves in the land and slay any evil dragons you find in them.\nOne of the dragons is friendly, however, and will help you on your quest!\nBut, first, you need to pick a character type:");

			Console.WriteLine("1.) Warrior");
			Console.WriteLine("2.) Mage");
			Console.WriteLine("3.) Druid");

			Console.Write("Enter your choice: ");
			var choice = int.Parse(Console.ReadLine());
			return HeroBase.Build(choice);
		}

	}
}
