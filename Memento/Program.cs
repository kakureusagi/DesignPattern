namespace Memento {

	class Program {
		static void Main(string[] args) {
			BoardPrinter printer = new BoardPrinter();

			var othello = new Othello();
			othello.Start(Color.White);

			othello.Set(3, 3);
			othello.Set(3, 4);
			othello.Set(4, 4);
			othello.Set(4, 3);

			printer.Print("オリジナル", othello);

			var snapshot = othello.Save();

			// 適当に石を追加しておく
			othello.Set(1, 1);
			othello.Set(5, 5);
			othello.Set(7, 7);

			printer.Print("オリジナル（追加後）", othello);

			// 復元
			var replay = new Othello();
			replay.Load(snapshot);
			printer.Print("復元", replay);
		}
	}

}