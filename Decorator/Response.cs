namespace Decorator {

	/// <summary>
	/// 通信のレスポンス
	/// </summary>
	class Response {
		
		/// <summary>
		/// 商品ID
		/// </summary>
		public string ProductId { get; set; }

		/// <summary>
		/// レシートの取り扱い
		/// </summary>
		public ReceiptConsumeType ConsumeType { get; set; }

		/// <summary>
		/// 完了時のダイアログのタイトル
		/// </summary>
		public string DialogTitle { get; set; }

		/// <summary>
		/// 完了時のダイアログの本文
		/// </summary>
		public string DialogBody { get; set; }


		public override string ToString() {
			return $"{nameof(ProductId)}: {ProductId}, {nameof(ConsumeType)}: {ConsumeType}, {nameof(DialogTitle)}: {DialogTitle}, {nameof(DialogBody)}: {DialogBody}";
		}
	}

}