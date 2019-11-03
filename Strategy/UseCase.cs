using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// 装備画面.
	/// </summary>
	class UseCase {

		readonly ILoader loader;
		readonly IRepository repository;

		public IEnumerable<Card> Cards => cards;
		Card[] cards;


		public UseCase(ILoader loader, IRepository repository) {
			this.loader = loader;
			this.repository = repository;
		}

		public async Task Prepare() {
			//
			// アタッチされているカードだけを選択する
			//

			loader.Show();
			var cards = await repository.GetCards();
			this.cards = cards.Where(card => card.IsEquipped).ToArray();

			loader.Hide();
		}
	}

}