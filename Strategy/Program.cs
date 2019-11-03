using System;
using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static async Task Main(string[] args) {
			var loader = new Loader();
			var repository = new Repository();
			var useCase = new UseCase(loader, repository);

			await useCase.Prepare();
			foreach (var card in useCase.Cards) {
				Console.WriteLine(card);
			}
		}
	}

}