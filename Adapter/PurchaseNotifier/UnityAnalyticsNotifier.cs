namespace Adapter {

	/// <summary>
	/// UnityAnalyticsに課金情報を通知するクラス.
	/// </summary>
	class UnityAnalyticsNotifier : IPurchaseNotifier {
		
		readonly UnityAnalytics analytics = new UnityAnalytics();
		
		
		public void Notify(Product product) {
			analytics.Notify(product.ProductId, product.Price);
		}

	}

}