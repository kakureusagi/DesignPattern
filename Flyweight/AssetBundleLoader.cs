using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Flyweight {

	/// <summary>
	/// アセットバンドルの読み込み担当
	/// </summary>
	class AssetBundleLoader {

		readonly Dictionary<string, AssetBundle> assetBundles = new Dictionary<string, AssetBundle>(1000);
		readonly Catalog catalog;
		readonly Dictionary<string, Item> items;

		public AssetBundleLoader(Catalog catalog) {
			this.catalog = catalog;
			items = new Dictionary<string, Item>(catalog.Items.Length);
			foreach (var item in catalog.Items) {
				items.Add(item.Path, item);
			}
		}

		public async Task<AssetBundle> GetAssetBundle(string path) {
			if (assetBundles.TryGetValue(path, out var assetBundle)) {
				return assetBundle;
			}

			var bytes = await LoadFromFile(path);
			var bundle = new AssetBundle(bytes);
			assetBundles.Add(path, bundle);
			return bundle;
		}

		private async Task<byte[]> LoadFromFile(string path) {
			// 実際にはファイルの存在チェックとかするでしょう
			Item item = items[path];

			using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.Asynchronous);
			var bytes = new byte[stream.Length];
			await stream.ReadAsync(bytes, 0, bytes.Length);

			return bytes;
		}


	}

}