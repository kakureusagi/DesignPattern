namespace Adapter {

	/// <summary>
	/// 課金の流れを制御する人.
	/// </summary>
	class UseCase {

		readonly IPurchaseNotifier notifier;
		readonly Product[] products;

		public UseCase(IPurchaseNotifier notifier, Product[] products) {
			this.notifier = notifier;
			this.products = products;
		}

		public void Purchase() {
			// 適当に全部の商品を買ったとする.
			foreach (var product in products) {
				notifier.Notify(product);
			}
		}

	}

	
	

}