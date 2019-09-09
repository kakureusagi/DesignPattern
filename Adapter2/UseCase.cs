namespace Adapter2 {

	/// <summary>
	/// ストーリーの再生や終了時の処理のフローを作る人
	/// </summary>
	class UseCase {

		private readonly IRepositoryAdapter adapter;

		public UseCase(IRepositoryAdapter adapter) {
			this.adapter = adapter;
		}

		public void OnStoryFinished() {
			adapter.FinishStory();
		}

	}

}