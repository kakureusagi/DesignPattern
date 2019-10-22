namespace AbstractFactory.Test {

	/// <summary>
	/// テスト用Sofa
	/// </summary>
	class TestSofa : Positionable, ISofa {

		public bool IsIdle { get; private set; }

		public bool HasCharacter { get; private set; }

		public TestSofa(int width, int height, int cost) : base(width, height, cost) {
		}

		public void StartIdleAnimation() {
			IsIdle = true;
		}
	}

}