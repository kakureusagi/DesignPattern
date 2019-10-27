using System;

namespace Bridge {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {

		static void Main(string[] args) {
			var ally = new Ally(new Human());
			ally.Think();
			ally.Think();

			Console.WriteLine("------");

			var monster = new Monster(new Dog());
			monster.Think();
			monster.Think();

			Console.WriteLine("------");

			var npc = new Npc(new SpecialHuman());
			npc.Think();
			npc.Think();

			Console.WriteLine("------");

			var extraMonster = new Monster(new SpecialHuman());
			extraMonster.Think();
			extraMonster.Think();
		}

	}

}