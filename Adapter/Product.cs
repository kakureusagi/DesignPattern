namespace Adapter {

	/// <summary>
	/// 課金情報.
	/// </summary>
	class Product {

		/// <summary>
		/// プロダクトID.
		/// </summary>
		public string ProductId { get; set; }
		
		/// <summary>
		/// 通貨コード.
		/// JPYとかUSDとかそういうの.
		/// </summary>
		public string Locale { get; set; }
		
		/// <summary>
		/// 価格.
		/// </summary>
		public int Price { get; set; }

	}

}