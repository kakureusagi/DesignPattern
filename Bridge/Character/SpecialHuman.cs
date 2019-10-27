using System;

namespace Bridge {

	/// <summary>
	/// 達人
	/// </summary>
	class SpecialHuman : ICharacter {

		public void Idle() {
			Console.WriteLine("SpecialHuman:Idle 優雅に立つ＋エフェクトも出る");
		}

		public void Walk() {
			Console.WriteLine("SpecialHuman:Walk ゆっくり歩く＋エフェクトも出る");
		}

		public void Attack() {
			Console.WriteLine("SpecialHuman:Attack すごい攻撃＋エフェクトも出る");
		}
	}

}