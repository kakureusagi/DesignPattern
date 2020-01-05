using System.Threading.Tasks;

namespace Observer {

	/// <summary>
	/// HTTP通信を行う
	/// </summary>
	class Http {

		public async Task<string> GetAsync() {
			// HTTP通信で適当な文字列が返ってきたとする
			await Task.Delay(100);
			return @"{""user"":{""id"":1},""data"":{""isSuccess"":true}}";
		}
	}

}