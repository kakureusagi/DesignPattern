using System.Threading.Tasks;

namespace Proxy {

	/// <summary>
	/// アセットバンドルのロードを行う
	/// </summary>
	interface IAssetBundleContainer {

		public Task<AssetBundle> LoadAsync(AssetBundleInfo info);
		public void Unload(AssetBundleInfo info);
	}

}