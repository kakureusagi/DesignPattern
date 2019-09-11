namespace TemplateMethod {

	/// <summary>
	/// アセットのインポート処理をまとめて実行する人
	/// </summary>
	public class AssetImportProcessor {

		public void Execute(IAssetImporter[] importers) {
			foreach (var importer in importers) {
				importer.Import();
			}
		}

	}

}