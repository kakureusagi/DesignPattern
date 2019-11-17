using System.Threading.Tasks;

namespace Decorator {

	/// <summary>
	/// 決済処理
	/// </summary>
	interface IRepository {

		/// <summary>
		/// 購入
		/// </summary>
		Task<Response> Purchase(string productId);
	}

}