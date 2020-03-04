using System;
using System.Threading.Tasks;

namespace Proxy {

	/// <summary>
	/// 実行者
	/// </summary>
	class UseCase {

		readonly IAssetBundleContainer container;

		public UseCase(IAssetBundleContainer container) {
			this.container = container;
		}

		public async Task Execute(AssetBundleInfo[] info) {
			Console.WriteLine("----------");
			foreach (var _info in info) {
				Console.WriteLine($"{_info.Path}の読み込みと破棄が行います。");
				await container.LoadAsync(_info);
				container.Unload(_info);
			}
		}
	}

}