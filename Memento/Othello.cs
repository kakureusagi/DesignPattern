using System;

namespace Memento {

	class Othello {

		static readonly int Size = 8;

		public Color[,] Board => board;
		public Color FirstColor => firstColor;
		public Color NextColor => nextColor;

		Color[,] board;
		Color firstColor;
		Color nextColor;


		public void Start(Color color) {
			if (color == Color.None) {
				throw new ArgumentOutOfRangeException(color.ToString());
			}

			firstColor = color;
			nextColor = color;
			board = new Color[Size, Size];
		}

		public void Set(int x, int y) {
			if (x < 0 || Size <= x || y < 0 || Size <= y) {
				throw new ArgumentOutOfRangeException($"x:{x}, y:{y}");
			}

			// 本当はここで石をひっくり返したりする
			// Mementoパターンの本質ではないのでカット

			board[x, y] = nextColor;
			nextColor = nextColor == Color.Black ? Color.White : Color.Black;
		}

		public Snapshot Save() {
			var copy = new Color[Size, Size];
			Array.Copy(board, copy, Size * Size);
			return new Snapshot {
				Board = copy,
				NextColor = nextColor,
				FirstColor = firstColor,
			};
		}

		public void Load(Snapshot snapshot) {
			board = snapshot.Board;
			firstColor = snapshot.FirstColor;
			nextColor = snapshot.NextColor;
		}
	}

}