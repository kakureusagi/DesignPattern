using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxy {

	/// <summary>
	/// 通常のアセットバンドルコンテナ
	/// </summary>
	class AssetBundleContainer : IAssetBundleContainer {

		readonly Dictionary<string, AssetBundle> cache = new Dictionary<string, AssetBundle>();

		public async Task<AssetBundle> LoadAsync(AssetBundleInfo info) {
			if (cache.TryGetValue(info.Path, out var cachedAssetBundle)) {
				return cachedAssetBundle;
			}

			// 実際にはファイルから読み込んだりするとする
			await Task.Delay(1000);
			var assetBundle = new AssetBundle {
				Data = new byte[info.Size],
			};

			cache.Add(info.Path, assetBundle);
			return assetBundle;
		}

		public void Unload(AssetBundleInfo info) {
			cache.Remove(info.Path);
		}
	}

}