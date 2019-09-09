using System;

namespace Adapter {

	/// <summary>
	/// UnityAnalyticsで提供されているクラスだとする.
	/// </summary>
	class UnityAnalytics {

		public void Notify(string productId, int price) {
			// ここできっとUnityAnalyticsがよしなに情報をアップロードしてくれる.
			Console.WriteLine($"UnityAnalytics用ログ product_id:{productId}, price:{price}");
		}
	}

}