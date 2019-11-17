namespace Decorator {

	/// <summary>
	/// レシートの取り扱いの種類
	/// </summary>
	enum ReceiptConsumeType {

		/// <summary>
		/// 消費
		/// </summary>
		Consume,

		/// <summary>
		/// レストア
		/// </summary>
		Restore,

		/// <summary>
		/// レシートを再取得してリトライ
		/// </summary>
		RefreshAndRetry,
	}

}