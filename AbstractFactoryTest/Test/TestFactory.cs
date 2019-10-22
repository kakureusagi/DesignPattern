namespace AbstractFactory.Test {

	/// <summary>
	/// テスト用Factory
	/// </summary>
	class TestFactory : IFactory {

		private readonly int[] costs;

		int costIndex;

		public TestFactory(int[] costs) {
			this.costs = costs;
		}

		public ISofa CreateSofa(int id) {
			var sofa = new TestSofa(3, 2, costs[costIndex]);
			++costIndex;
			return sofa;
		}

		public ICharacter CreateCharacter(int id) {
			var character = new TestCharacter(3, 2, costs[costIndex]);
			++costIndex;
			return character;
		}
	}

}