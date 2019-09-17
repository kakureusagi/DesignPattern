namespace FactoryMethod {

	/// <summary>
	/// デバッグ用テトリミノ生成ファクトリ
	/// </summary>
	class DebugTetriminoFactory : TetriminoFactoryBase {

		/// <summary>
		/// TetriminoTypeとColorの組み合わせ
		/// </summary>
		class Set {

			public TetriminoType Type { get; set; }
			public string Color { get; set; }

		}

		/// <summary>
		/// どこかファイルにこれが記載されているとする
		/// </summary>
		readonly Set[] setsFromFile = {
			new Set {Type = TetriminoType.I, Color = "light_blue"},
			new Set {Type = TetriminoType.I, Color = "light_blue"},
			new Set {Type = TetriminoType.I, Color = "light_blue"},
			new Set {Type = TetriminoType.I, Color = "light_blue"},
			new Set {Type = TetriminoType.T, Color = "purple"},
			new Set {Type = TetriminoType.T, Color = "purple"},
			new Set {Type = TetriminoType.T, Color = "purple"},
		};

		int index;
		
		protected override Tetrimino CreateTetrimino() {
			// ファイルに保存された情報からテトリミノを生成する
			var set = setsFromFile[index];

			++index;
			if (index >= setsFromFile.Length) {
				index = 0;
			}
			
			return new Tetrimino {
				Type = set.Type,
				Color = set.Color,
			};
		}

	}

}