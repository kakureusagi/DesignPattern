using System;

namespace Adapter {

	/// <summary>
	/// Adjustから提供されているSDKが提供しているクラスだとする.
	/// </summary>
	class Adjust {

		readonly string companyId;

		string productId;
		string locale;
		int price;



		public Adjust(string companyId) {
			this.companyId = companyId;
		}

		public void SetProductId(string productId) {
			this.productId = productId;
		}

		public void SetPrice(int price) {
			this.price = price;
		}

		public void SetLocale(string locale) {
			this.locale = locale;
		}

		public void Upload() {
			// ここできっとAdjustがよしなに情報をアップロードしてくれる.
			Console.WriteLine($"Adjust用ログ companyId:{companyId}, product_id:{productId}, locale:{locale}, price:{price}");
			productId = default;
			locale = default;
			price = default;
		}

	}

}