using System;

namespace FactoryMethod {

	/// <summary>
	/// 通常時のテトリミノ生成ファクトリ
	/// </summary>
	class TetriminoFactory : TetriminoFactoryBase {

		/// <summary>
		/// TetriminoTypeとColorの組み合わせ
		/// </summary>
		class Set {

			public TetriminoType Type { get; set; }
			public string Color { get; set; }

		}

		readonly Set[] sets = {
			new Set {Type = TetriminoType.I, Color = "light_blue"},
			new Set {Type = TetriminoType.O, Color = "yellow"},
			new Set {Type = TetriminoType.Z, Color = "red"},
			new Set {Type = TetriminoType.S, Color = "yellow_green"},
			new Set {Type = TetriminoType.J, Color = "blue"},
			new Set {Type = TetriminoType.L, Color = "orange"},
			new Set {Type = TetriminoType.T, Color = "purple"},
		};

		readonly Random random;

		public TetriminoFactory(int seed) {
			random = new Random(seed);
		}

		protected override Tetrimino CreateTetrimino() {
			// ランダムに生成
			int randomIndex = random.Next(0, sets.Length - 1);
			Set set = sets[randomIndex];
			
			return new Tetrimino {
				Type = set.Type,
				Color = set.Color,
			};
		}

	}

}