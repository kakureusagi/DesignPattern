using System.Threading.Tasks;

namespace Observer {

	/// <summary>
	/// 画面で必要な情報の取得を担当
	/// </summary>
	interface IRepository {
		Task<SceneData> GetSceneData();
	}

	class Repository : IRepository {

		readonly IApplicationHttpFactory factory;

		public Repository(IApplicationHttpFactory factory) {
			this.factory = factory;
		}

		public async Task<SceneData> GetSceneData() {
			var applicationHttp = factory.Create();
			var response = await applicationHttp.GetAsync();
			return response.Data;
		}
	}

}