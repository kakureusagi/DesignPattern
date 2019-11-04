using System;

namespace Strategy {

	/// <summary>
	/// ローダー画面のON/OFF制御
	/// </summary>
	class Loader : ILoader {

		public void Show() {
			Console.WriteLine($"{nameof(Loader)}.{nameof(Show)}");
		}

		public void Hide() {
			Console.WriteLine($"{nameof(Loader)}.{nameof(Hide)}");
		}
	}

}