namespace AbstractFactory {

	/// <summary>
	/// 本番用のFactory
	/// </summary>
	class Factory : IFactory {

		public ISofa CreateSofa(int id) {
			return new Sofa(new Animator(), 3, 2, id);
		}

		public ICharacter CreateCharacter(int id) {
			return new Character(new Animator(), 1, 1, id);
		}
	}

}