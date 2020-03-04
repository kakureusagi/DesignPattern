using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy {

	/// <summary>
	/// LRUアルゴリズムでキャッシュするコンテナ
	/// </summary>
	class LruAssetBundleContainer : IAssetBundleContainer {

		class CacheData {
			public AssetBundle AssetBundle { get; set; }
			public uint Generation { get; set; }
		}


		readonly Dictionary<AssetBundleInfo, CacheData> cache = new Dictionary<AssetBundleInfo, CacheData>();
		readonly AssetBundleContainer container;
		readonly long maxCacheSize;
		readonly long minCacheSize;
		uint generation;
		long cacheSize;


		public LruAssetBundleContainer(AssetBundleContainer container, long maxCacheSize, long minCacheSize) {
			this.container = container;
			this.maxCacheSize = maxCacheSize;
			this.minCacheSize = minCacheSize;
		}

		public async Task<AssetBundle> LoadAsync(AssetBundleInfo info) {
			if (cache.TryGetValue(info, out var cacheData)) {
				++generation;
				cacheData.Generation = generation;
				return cacheData.AssetBundle;
			}

			// キャッシュの上限サイズを超えたら古いのから削除
			if (cacheSize + info.Size > maxCacheSize) {
				foreach (var pair in cache.OrderBy(pair => pair.Value.Generation)) {
					container.Unload(pair.Key);
					cacheSize -= pair.Key.Size;
					if (cacheSize <= minCacheSize) {
						break;
					}
				}
			}

			var assetBundle = await container.LoadAsync(info);

			++generation;
			cacheSize += info.Size;
			var data = new CacheData {
				Generation = generation,
				AssetBundle = assetBundle,
			};

			cache.Add(info, data);
			return assetBundle;
		}

		public void Unload(AssetBundleInfo info) {
			// 何もしない.
		}
	}

}