using System;
using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// 通信してカード情報を取得する
	/// </summary>
	class Repository : IRepository {

		public async Task<Card[]> GetCards() {
			Console.WriteLine("GetCard started");
			await Task.Delay(10);
			Console.WriteLine("GetCard finished");

			return new[] {
				new Card {Id = 1, IsEquipped = true,},
				new Card {Id = 2, IsEquipped = false,},
				new Card {Id = 3, IsEquipped = true,},
			};
		}
	}

}