using System;

namespace TemplateMethod {

	/// <summary>
	/// 3DModelのインポーター.
	/// </summary>
	public abstract class ModelImporter : IAssetImporter {

		protected readonly string assetPath;


		protected ModelImporter(string assetPath) {
			this.assetPath = assetPath;
		}

		public void Import() {
			OnPreProcess();
			var model = RegisterModel();
			OnPostProcess(model);
		}

		private Model RegisterModel() {
			// 実際にはここでテクスチャをインポート処理を行って、AssetDatabaseへの登録とか行うでしょう
			Console.WriteLine($"register model in asset database. assetPath:{assetPath}");

			// 適当にモデルっぽいの作る
			return new Model(new byte[0]);
		}

		protected virtual void OnPreProcess() {
		}

		protected virtual void OnPostProcess(Model model) {
		}

	}

}