namespace TemplateMethod {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {

		static void Main(string[] args) {

			var textureImporter = new IAssetImporter[] {
				new TwoTextureImporter("2d/a.png"),
				new TwoTextureImporter("2d/b.png"),
				new ThreeTextureImporter("3d/b.png"),
				new ThreeTextureImporter("3d/b.png"),
				new ComplexModelImporter("3d/model/e.fbx"),
			};

			new AssetImportProcessor().Execute(textureImporter);

		}

	}

}