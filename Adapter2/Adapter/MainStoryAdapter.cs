namespace Adapter2 {

	/// <summary>
	/// イベントストーリー用のAdapter
	/// </summary>
	class MainStoryAdapter : IRepositoryAdapter {

		private readonly MainStoryRepository repository;
		private readonly int mainStoryId;
		private readonly int mainStorySectionId;


		public MainStoryAdapter(MainStoryRepository repository, int mainStoryId, int mainStorySectionId) {
			this.repository = repository;
			this.mainStoryId = mainStoryId;
			this.mainStorySectionId = mainStorySectionId;
		}

		public void FinishStory() {
			repository.FinishMainStory(mainStoryId, mainStorySectionId);
		}

	}

}