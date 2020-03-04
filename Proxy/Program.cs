using System.Threading.Tasks;

namespace Proxy {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static async Task Main(string[] args) {
			var info = new AssetBundleInfo[] {
				new AssetBundleInfo {
					Path = "aaa",
					Size = 10,
				},
				new AssetBundleInfo {
					Path = "bbb",
					Size = 20,
				},
				new AssetBundleInfo {
					Path = "aaa",
					Size = 10,
				},
				new AssetBundleInfo {
					Path = "bbb",
					Size = 20,
				},
			};

			// プロキシじゃない方
			var nonProxyUseCase = new UseCase(new AssetBundleContainer());
			await nonProxyUseCase.Execute(info);

			// プロキシな方
			var proxyUseCase = new UseCase(new LruAssetBundleContainer(new AssetBundleContainer(), 1000, 100));
			await proxyUseCase.Execute(info);
		}
	}

}