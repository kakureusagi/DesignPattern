using System;
using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// 通信してカード情報を取得する
	/// </summary>
	class Repository : IRepository {

		public async Task<Card[]> GetCards() {
			// ここはAPI通信で取得しているとする
			await Task.Delay(10);

			return new[] {
				new Card {Id = 1, IsEquipped = true,},
				new Card {Id = 2, IsEquipped = false,},
				new Card {Id = 3, IsEquipped = true,},
			};
		}
	}

}