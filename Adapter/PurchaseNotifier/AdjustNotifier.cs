namespace Adapter {

	/// <summary>
	/// Adjustに課金情報と伝えるクラス.
	/// </summary>
	class AdjustNotifier : IPurchaseNotifier {

		// Adjustの管理画面とかに記載されてるID.
		static readonly string CompanyId = "release_company_id";
		
		// きっと本番用とテスト用で用意されているので、必要に応じてシンボルとかで切り替える.
		// static readonly string CompanyId = "test_company_id";.
		
		/// <summary>
		/// ここでnewしてると、このクラスの単体テストは行えなくなっちゃう.
		/// けど、アダプターの中の処理が複雑になることは少ないと思うので、そもそもテスト不要でしょう.
		/// </summary>
		readonly Adjust adjust = new Adjust(CompanyId);

		
		
		public void Notify(Product product) {
			adjust.SetProductId(product.ProductId);
			adjust.SetLocale(product.Locale);
			adjust.SetPrice(product.Price);
			adjust.Upload();
		}

	}

}