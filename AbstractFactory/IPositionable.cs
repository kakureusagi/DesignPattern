namespace AbstractFactory {

	/// <summary>
	/// ポジション設定可能
	/// </summary>
	public interface IPositionable {
		int X { get; }
		int Y { get; }
		int Width { get; }
		int Height { get; }

		int Cost { get; }

		void SetX(int x);
		void SetY(int y);
	}

}