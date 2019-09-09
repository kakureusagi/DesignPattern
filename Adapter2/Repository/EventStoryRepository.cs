using System;

namespace Adapter2 {

	/// <summary>
	/// イベントストーリー用のAPIとか.
	/// </summary>
	class EventStoryRepository {

		public void FinishEventStory(int eventStoryId) {
			// ここで実際にはAPIサーバーにリクエストを投げるとする.
			Console.WriteLine($"Event story finished, eventStoryId:{eventStoryId}");
		}

	}

}