using System.Threading.Tasks;

namespace Decorator {

	/// <summary>
	/// 本番用のRepository
	/// </summary>
	class ReleaseRepository : IRepository {

		public async Task<Response> Purchase(string productId) {
			// 普通のAPIを呼び出す
			await Task.Delay(10);

			return new Response {
				ProductId = productId,
				ConsumeType = ReceiptConsumeType.Consume,
				DialogTitle = "購入完了",
				DialogBody = "正常にアイテムの購入が完了しました！",
			};
		}
	}

}