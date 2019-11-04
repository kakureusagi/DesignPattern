using System;
using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static async Task Main(string[] args) {
			var debugInspectorCards = new[] {
				new Card {Id = 997, IsEquipped = true},
				new Card {Id = 998, IsEquipped = true},
				new Card {Id = 999, IsEquipped = true},
			};
			
			await Run(new Loader(), new Repository());
			await Run(new DebugLoader(), new UnityInspectorRepository(debugInspectorCards));
		}

		static async Task Run(ILoader loader, IRepository repository) {
			Console.WriteLine("-----");
			
			var useCase = new UseCase(loader, repository);
			await useCase.Prepare();
			
			foreach (var card in useCase.Cards) {
				Console.WriteLine(card);
			}
		}
	}

}