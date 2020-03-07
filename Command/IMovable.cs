using System.Numerics;

namespace Command {

	/// <summary>
	/// 移動できるオブジェクト
	/// </summary>
	interface IMovable {

		public Vector2 Position { get; set; }
		public float Speed { get; }
	}

}