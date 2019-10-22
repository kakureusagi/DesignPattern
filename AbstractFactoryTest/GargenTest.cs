using System.Linq;
using FluentAssertions;
using Xunit;

namespace AbstractFactory.Test {

	public class GargenTest {

		readonly IFactory factory;

		public GargenTest() {
			factory = new TestFactory(Enumerable.Range(1, 10).ToArray());
		}


		[Fact(DisplayName = "キャラクターが作成できる")]
		public void CreateCharacterTest() {
			var garden = new Garden(factory, 10, 10);
			var character = garden.CreateCharacter(1) as TestCharacter;
			character.Cost.Should().Be(1);
			character.Motion.Should().Be(Motion.Walk);
		}

		[Fact(DisplayName = "ソファが作成できる")]
		public void CreateSofaTest() {
			var garden = new Garden(factory, 10, 10);
			var sofa = garden.CreateSofa(1) as TestSofa;
			sofa.Cost.Should().Be(1);
			sofa.IsIdle.Should().BeTrue();
		}

		[Fact(DisplayName = "コスト計算が正しく行われる")]
		public void CalculateCostTest() {
			const int userCost = 10;

			var garden = new Garden(factory, userCost, 10);
			garden.RestCost.Should().Be(userCost);

			var character = garden.CreateCharacter(1);
			garden.RestCost.Should().Be(userCost - 1);

			var sofa = garden.CreateSofa(2);
			garden.RestCost.Should().Be(userCost - 1 - 2);

			garden.DeleteCharacter(character);
			garden.RestCost.Should().Be(userCost - 2);

			garden.DeleteSofa(sofa);
			garden.RestCost.Should().Be(userCost);
		}


		[Fact(DisplayName = "設置数が正しく計算される")]
		public void CalculateInstallationNumberTest() {
			const int maxInstallationNumber = 20;

			var garden = new Garden(factory, 10, maxInstallationNumber);
			garden.RestInstallationNumber.Should().Be(maxInstallationNumber);

			var character = garden.CreateCharacter(1);
			garden.RestInstallationNumber.Should().Be(maxInstallationNumber - 1);

			var sofa = garden.CreateSofa(2);
			garden.RestInstallationNumber.Should().Be(maxInstallationNumber - 2);

			garden.DeleteCharacter(character);
			garden.RestInstallationNumber.Should().Be(maxInstallationNumber - 1);

			garden.DeleteSofa(sofa);
			garden.RestInstallationNumber.Should().Be(maxInstallationNumber);
		}
	}

}