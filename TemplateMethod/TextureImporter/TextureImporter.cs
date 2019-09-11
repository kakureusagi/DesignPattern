using System;

namespace TemplateMethod {

	/// <summary>
	/// テクスチャインポーター
	/// </summary>
	public abstract class TextureImporter : IAssetImporter {

		protected readonly string assetPath;

		protected TextureImporter(string assetPath) {
			this.assetPath = assetPath;
		}

		public void Import() {
			OnPreProcess();
			var texture = RegisterTexture();
			OnPostProcess(texture);
		}

		private Texture RegisterTexture() {
			// 実際にはここでテクスチャをインポート処理を行って、AssetDatabaseへの登録とか行うでしょう
			Console.WriteLine($"register texture in asset database. assetPath:{assetPath}");

			// 適当にテクスチャっぽいの作る
			return new Texture(4, 4, new byte[16]);
		}

		protected virtual void OnPreProcess() {
		}

		protected virtual void OnPostProcess(Texture texture) {
		}

	}

}