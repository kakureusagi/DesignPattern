namespace FactoryMethod {

	/// <summary>
	/// テトリミノ生成ファクトリの基底クラス
	/// 生成以外の処理はこのクラスが担当することにする
	/// </summary>
	abstract class TetriminoFactoryBase {

		public Tetrimino Create() {
			// テトリミノの生成は全て継承先に委ねる
			var tetrimino = CreateTetrimino();
			
			// 適当に一番上に持ってくるとする
			tetrimino.X = 3;
			tetrimino.Y = 0;
			
			return tetrimino;
		}
		
		protected abstract Tetrimino CreateTetrimino();

	}

}