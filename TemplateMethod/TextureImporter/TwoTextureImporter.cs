using System;

namespace TemplateMethod {

	/// <summary>
	/// 2D用のテクスチャインポーター
	/// </summary>
	public class TwoTextureImporter : TextureImporter {

		public TwoTextureImporter(string assetPath) : base(assetPath) {
		}

		protected override void OnPreProcess() {
			base.OnPreProcess();
			Console.WriteLine($"on 2D texture preprocess. assetPath:{assetPath}");
		}

		protected override void OnPostProcess(Texture texture) {
			base.OnPostProcess(texture);
			Console.WriteLine($"on 2D texture postprocess. assetPath:{assetPath}");
		}

	}

}