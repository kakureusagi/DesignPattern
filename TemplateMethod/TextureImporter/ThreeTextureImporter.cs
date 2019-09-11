using System;

namespace TemplateMethod {

	/// <summary>
	/// 3D用のテクスチャインポーター
	/// </summary>
	public class ThreeTextureImporter : TextureImporter {

		public ThreeTextureImporter(string assetPath) : base(assetPath) {
		}

		protected override void OnPreProcess() {
			base.OnPreProcess();
			Console.WriteLine($"on 3D texture preprocess. assetPath:{assetPath}");
		}

		protected override void OnPostProcess(Texture texture) {
			base.OnPostProcess(texture);
			Console.WriteLine($"on 3D texture postprocess. assetPath:{assetPath}");
		}

	}

}