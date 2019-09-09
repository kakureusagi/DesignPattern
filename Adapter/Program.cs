namespace Adapter {

	/// <summary>
	/// エントリーポイント.
	/// </summary>
	class Program {

		static void Main(string[] args) {

			var products = new [] {
				new Product {
					ProductId = "product_id_1",
					Price = 100,
					Locale = "JPY",
				},
				new Product {
					ProductId = "product_id_2",
					Price = 200,
					Locale = "USD",
				},
				new Product {
					ProductId = "product_id_3",
					Price = 300,
					Locale = "JPY",
				},
			};

			Execute(new UnityAnalyticsNotifier(), products);
			Execute(new EditorNotifier(), products);
			Execute(new AdjustNotifier(), products);
		}

		static void Execute(IPurchaseNotifier notifier, Product[] products) {
			new UseCase(notifier, products).Purchase();
		}
	}

}