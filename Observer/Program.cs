using System.Threading.Tasks;

namespace Observer {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {

		static async Task Main(string[] args) {
			// 永続的なシーンを初期化しておいて
			var systemScene = new SystemScene();
			systemScene.Run();

			// 画面を構成していく
			var repository = new Repository(ApplicationHttpFactory.Instance);
			var useCase = new UseCase(repository);
			await useCase.Prepare();
		}
	}

}