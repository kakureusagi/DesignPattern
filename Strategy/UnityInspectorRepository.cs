using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// UnityのInspectorで設定した情報を使うRepository
	/// </summary>
	class UnityInspectorRepository : IRepository {

		readonly Card[] cards;


		public UnityInspectorRepository(Card[] cards) {
			this.cards = cards;
		}

		public async Task<Card[]> GetCards() {
			await Task.Delay(10);

			// UnityのInspectorなどで記述したObjectを返すとする
			return cards;
		}
	}

}