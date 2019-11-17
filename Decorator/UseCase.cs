using System;
using System.Threading.Tasks;

namespace Decorator {

	/// <summary>
	/// 画面の処理担当
	/// </summary>
	class UseCase {

		readonly IRepository repository;

		public UseCase(IRepository repository) {
			this.repository = repository;
		}

		public async Task Run() {
			var result = await repository.Purchase("test_product_id");
			Console.WriteLine(result.ToString());
		}
	}

}