using System;

namespace Adapter2 {

	/// <summary>
	/// チュートリアル用のAdapter
	/// </summary>
	class TutorialStoryAdapter : IRepositoryAdapter {

		public void FinishStory() {
			// このクラスは通信しなかったりする
			Console.WriteLine($"Tutorial story is finished.");
		}

	}

}