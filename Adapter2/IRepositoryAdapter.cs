namespace Adapter2 {

	/// <summary>
	/// アダプターインターフェース
	/// サーバーにストーリー読了通知を送る処理の詳細を隠す
	/// </summary>
	interface IRepositoryAdapter {

		void FinishStory();

	}

}