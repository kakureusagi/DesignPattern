using System;

namespace Adapter {

	/// <summary>
	/// UnityのEditor用の実装.
	/// </summary>
	class EditorNotifier : IPurchaseNotifier {

		public void Notify(Product product) {
			// 特に通知先は存在しないので雑にログにだしとく.
			Console.WriteLine($"Editor用ログ product_id:{product.ProductId}, price:{product.Price}");
		}

	}

}