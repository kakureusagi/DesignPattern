using System.Threading.Tasks;

namespace Decorator {

	/// <summary>
	/// デバッグ用のRepository
	/// </summary>
	class DebuggerRepository : IRepository {

		readonly IRepository repository;
		readonly Debugger debugger;


		public DebuggerRepository(IRepository repository, Debugger debugger) {
			this.repository = repository;
			this.debugger = debugger;
		}

		public async Task<Response> Purchase(string productId) {
			if (debugger.IsPurchaseDebugEnabled) {
				return await PurchaseForDebug(productId, debugger.ErrorCode);
			}

			return await repository.Purchase(productId);
		}

		private async Task<Response> PurchaseForDebug(string productId, int errorCode) {
			// APIサーバーが課金サーバーから受け取ったエラーコードに応じて、メッセージなどの振り分けを行うとする
			await Task.Delay(10);

			ReceiptConsumeType type;
			string title;
			string body;

			if (errorCode < 1000) {
				type = ReceiptConsumeType.Consume;
				title = "消費完了";
				body = "消費完了";
			}
			else if (errorCode < 2000) {
				type = ReceiptConsumeType.Restore;
				title = "レストア";
				body = "レストアしてね";
			}
			else {
				type = ReceiptConsumeType.RefreshAndRetry;
				title = "レシート再取得";
				body = "レシート再取得してリトライしてね";
			}

			return new Response {
				ProductId = productId,
				ConsumeType = type,
				DialogTitle = title,
				DialogBody = body,
			};
		}
	}

}