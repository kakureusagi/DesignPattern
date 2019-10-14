using System;
using System.Threading.Tasks;

namespace Builder {

	class Program {

		static async Task Main(string[] args) {
			// シンプルパターン
			var text1 = await new Request.Builder()
				.Url("https://google.com111")
				.Get()
				.Build()
				.RequestAsync();
			Console.WriteLine(text1);

			// 複雑パターン
			var text2 = await new Request.Builder()
				.Url("https://google.com222")
				.Post("post data")
				.Header("Accept-Encoding", "gzip, deflate")
				.Timeout(TimeSpan.FromSeconds(45))
				.KeepAlive()
				.Build()
				.RequestAsync();
			Console.WriteLine(text2);
		}
	}

}