namespace Decorator {

	/// <summary>
	/// SrDebugger的な何か
	/// </summary>
	public class Debugger {

		/// <summary>
		/// 購入処理でデバッグを有効にする
		/// </summary>
		public bool IsPurchaseDebugEnabled { get; set; }

		/// <summary>
		/// 課金サーバーから帰ってくるシミュレーション用エラーコード
		/// </summary>
		public int ErrorCode { get; set; }

	}

}