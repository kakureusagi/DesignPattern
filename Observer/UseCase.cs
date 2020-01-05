using System;
using System.Threading.Tasks;

namespace Observer {

	/// <summary>
	/// 画面のロジックを担当
	/// </summary>
	class UseCase {

		readonly IRepository repository;

		public UseCase(IRepository repository) {
			this.repository = repository;
		}

		public async Task Prepare() {
			// 画面に必要なデータを取得して、色々画面を作っていく
			// このタイミングでSystemSceneでユーザーデータが自動的に更新される
			var sceneData = await repository.GetSceneData();
			Console.WriteLine($"[{nameof(UseCase)}] IsSuccess:{sceneData.IsSuccess}");
		}
	}

}