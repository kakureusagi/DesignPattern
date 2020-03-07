using System;
using System.Numerics;

namespace Command {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static void Main(string[] args) {
			// RTS（Real Time strategy）ゲームを初期化するとする
			var executor = new CommandExecutor();
			var fighter = new Fighter();
			var battle = new Battle(executor, fighter);

			Console.WriteLine(fighter.Position);

			// ネットワーク越しにコマンドが到着して、時間が進んだとする
			executor.OnReceiveCommand(new MoveCommand(fighter, new Vector2(10, 10)));
			battle.Update(5);
			Console.WriteLine(fighter.Position);
			battle.Update(10);
			Console.WriteLine(fighter.Position);

			// ネットワーク越しにコマンドが到着して、時間が進んだとする
			executor.OnReceiveCommand(new MoveCommand(fighter, new Vector2(100, 100)));
			battle.Update(45);
			Console.WriteLine(fighter.Position);
			battle.Update(200);
			Console.WriteLine(fighter.Position);
		}

	}

}