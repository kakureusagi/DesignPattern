using System;

namespace State {

	class Program {
		static void Main(string[] args) {
			var input = new Input();
			input.SetForwardButton(true);
			var player = new Player();

			var useCase = new UseCase(input, player);
			useCase.Run();
			for (var i = 0; i < 100; i++) {
				useCase.Update(0.9f);
				Console.WriteLine($"Frame: {i} State: {useCase.State}, PlayerPosition: {player.Position:0.00}m");

				if (useCase.State == State.Goal) {
					break;
				}
			}
			
		}
	}

}