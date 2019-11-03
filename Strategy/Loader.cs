using System;

namespace Strategy {

	/// <summary>
	/// ローダー画面のON/OFF制御
	/// </summary>
	class Loader : ILoader {

		public void Show() {
			Console.WriteLine("Activate Loader");
		}

		public void Hide() {
			Console.WriteLine("Deactivate Loader");
		}
	}

}