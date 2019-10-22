namespace AbstractFactory {

	/// <summary>
	/// ハコニワの基本クラス
	/// </summary>
	public abstract class Positionable : IPositionable {

		public int X { get; private set; }
		public int Y { get; private set; }
		public int Width { get; }
		public int Height { get; }
		public int Cost { get; }


		protected Positionable(int width, int height, int cost) {
			Width = width;
			Height = height;
			Cost = cost;
		}

		public void SetX(int x) {
			X = x;
		}

		public void SetY(int y) {
			Y = y;
		}
	}

}