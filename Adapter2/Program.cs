namespace Adapter2 {

	/// <summary>
	/// エントリーポイント
	/// </summary>
	class Program {

		static void Main(string[] args) {

			Execute(new MainStoryAdapter(new MainStoryRepository(), 1, 2));
			Execute(new EventStoryAdapter(new EventStoryRepository(), 3));
			Execute(new TutorialStoryAdapter());
		}

		static void Execute(IRepositoryAdapter adapter) {
			new UseCase(adapter).OnStoryFinished();
		}

	}

}