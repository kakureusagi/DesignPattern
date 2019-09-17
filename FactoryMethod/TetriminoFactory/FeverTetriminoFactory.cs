namespace FactoryMethod {

	/// <summary>
	/// フィーバー時用テトリミノ生成ファクトリ
	/// </summary>
	class FeverTetriminoFactory : TetriminoFactoryBase {

		protected override Tetrimino CreateTetrimino() {
			// I型ばっかり作る
			return new Tetrimino {
				Type = TetriminoType.L,
				Color = "blue",
			};
		}

	}

}