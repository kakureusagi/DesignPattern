namespace AbstractFactory.Test {

	/// <summary>
	/// テスト用Character
	/// </summary>
	class TestCharacter : Positionable, ICharacter {

		public Motion Motion { get; private set; } = Motion.None;


		public TestCharacter(int width, int height, int cost) : base(width, height, cost) {
		}

		public void StartWalkAnimation() {
			Motion = Motion.Walk;
		}
	}

}