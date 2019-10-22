namespace AbstractFactory {

	/// <summary>
	/// ハコニワ
	/// </summary>
	public class Garden {

		public int RestCost => userCost - totalCost;
		public int RestInstallationNumber => maxInstallationNumber - installationNumber;

		readonly IFactory factory;
		readonly int userCost;
		readonly int maxInstallationNumber;

		int totalCost;
		int installationNumber;


		public Garden(IFactory factory, int userCost, int maxInstallationNumber) {
			this.factory = factory;
			this.userCost = userCost;
			this.maxInstallationNumber = maxInstallationNumber;
		}

		public ICharacter CreateCharacter(int id) {
			var character = factory.CreateCharacter(id);
			character.StartWalkAnimation();
			totalCost += character.Cost;
			++installationNumber;
			return character;
		}

		public ISofa CreateSofa(int id) {
			var sofa = factory.CreateSofa(id);
			sofa.StartIdleAnimation();
			totalCost += sofa.Cost;
			++installationNumber;
			return sofa;
		}

		public void DeleteCharacter(ICharacter character) {
			totalCost -= character.Cost;
			--installationNumber;
		}

		public void DeleteSofa(ISofa sofa) {
			totalCost -= sofa.Cost;
			--installationNumber;
		}

	}

}