namespace Adapter2 {

	/// <summary>
	/// イベントストーリー用のAdapter
	/// </summary>
	class EventStoryAdapter : IRepositoryAdapter {

		readonly EventStoryRepository repository;
		private readonly int eventStoryId;


		public EventStoryAdapter(EventStoryRepository repository, int eventStoryId) {
			this.repository = repository;
			this.eventStoryId = eventStoryId;
		}

		public void FinishStory() {
			repository.FinishEventStory(eventStoryId);
		}

	}

}