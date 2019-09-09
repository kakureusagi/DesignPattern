namespace Adapter {

	/// <summary>
	/// 決済した課金情報をKPIサービスへ通知することが担当.
	/// </summary>
	interface IPurchaseNotifier {

		/// <summary>
		/// 通知する.
		/// </summary>
		void Notify(Product product);

	}

}