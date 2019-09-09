using System;

namespace Adapter2 {

	/// <summary>
	/// メインストーリー用のAPIとか.
	/// </summary>
	class MainStoryRepository {

		public void FinishMainStory(int mainStoryId, int mainStorySectionId) {
			// ここで実際にはAPIサーバーにリクエストを投げるとする.
			Console.WriteLine($"Main story finished. mainStoryId:{mainStoryId}, mainStorySectionId:{mainStorySectionId}");
		}

	}

}