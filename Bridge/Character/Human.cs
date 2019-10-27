using System;

namespace Bridge {

	/// <summary>
	/// 人間
	/// </summary>
	class Human : ICharacter {

		public void Idle() {
			Console.WriteLine("Human:Idle 棒立ち");
		}

		public void Walk() {
			Console.WriteLine("Human:Walk ゆっくり歩く");
		}

		public void Attack() {
			Console.WriteLine("Human:Attack 普通の攻撃");
		}
	}

}