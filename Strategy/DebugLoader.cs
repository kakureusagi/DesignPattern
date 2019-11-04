using System;

namespace Strategy {

	/// <summary>
	/// なにかデバッグ用のローダー
	/// </summary>
	public class DebugLoader : ILoader {

		public void Show() {
			Console.WriteLine($"{nameof(DebugLoader)}.{nameof(Show)}");
		}

		public void Hide() {
			Console.WriteLine($"{nameof(DebugLoader)}.{nameof(Hide)}");
		}
	}

}