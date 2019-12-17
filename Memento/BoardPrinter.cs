using System;
using System.Linq;

namespace Memento {

	class BoardPrinter {

		public void Print(string memo, Othello othello) {
			var width = othello.Board.GetLength(0);
			var height = othello.Board.GetLength(1);

			Console.WriteLine(memo);
			Console.WriteLine($"First: {GetColorString(othello.FirstColor)}, Next: {GetColorString(othello.NextColor)}");
			for (var y = 0; y < height; y++) {
				var row = Enumerable.Range(0, width)
					.Select(i => GetColorString(othello.Board[i, y]))
					.Aggregate((b, a) => b + a);
				Console.WriteLine(row);
			}
		}


		private string GetColorString(Color color) {
			switch (color) {
				case Color.None:
					return "-";
				case Color.White:
					return "○";
				case Color.Black:
					return "●";
				default:
					throw new ArgumentOutOfRangeException(nameof(color), color, null);
			}
		}

	}

}