using System;

namespace FactoryMethod {

	/// <summary>
	/// ファクトリ使う人
	/// </summary>
	class UseCase {

		readonly TetriminoFactoryBase factory;

		public UseCase(TetriminoFactoryBase factory) {
			this.factory = factory;
		}

		public void Execute() {
			// 適当にテトリミノ作る
			for (int i = 0; i < 7; i++) {
				var tetrimino = factory.Create();
				Console.WriteLine($"type:{tetrimino.Type}, color:{tetrimino.Color}");
			}
		}
	}

}