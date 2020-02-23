namespace Flyweight {

	/// <summary>
	/// アセットバンドル
	/// </summary>
	public class AssetBundle {

		readonly byte[] data;

		public AssetBundle(byte[] data) {
			this.data = data;
		}

		public string GetTexture() {
			// 実際にはテクスチャとかメッシュとか返す
			return $"AssetBundleのサイズは{data.Length}byte.";
		}
	}

}