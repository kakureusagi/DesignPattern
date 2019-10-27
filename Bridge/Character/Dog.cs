using System;

namespace Bridge {

	/// <summary>
	/// ペットの犬
	/// </summary>
	class Dog : ICharacter {

		public void Idle() {
			Console.WriteLine("Dog:Idle 座る");
		}

		public void Walk() {
			Console.WriteLine("Dog:Walk せわしなく歩く");
		}

		public void Attack() {
			Console.WriteLine("Dog:Attack 早い攻撃");
		}
	}

}