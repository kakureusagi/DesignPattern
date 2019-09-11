using System;

namespace TemplateMethod {

	/// <summary>
	/// 複雑なモデルのインポーター.
	/// </summary>
	public class ComplexModelImporter : ModelImporter {

		public ComplexModelImporter(string assetPath) : base(assetPath) {
		}

		protected override void OnPreProcess() {
			base.OnPreProcess();
			Console.WriteLine($"on model preprocess. assetPath:{assetPath}");
		}

		protected override void OnPostProcess(Model model) {
			base.OnPostProcess(model);
			Console.WriteLine($"on model postprocess. assetPath:{assetPath}");
		}

	}

}