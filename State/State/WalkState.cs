using System;

namespace State {

	class WalkState : IState {
		
		private static readonly float Speed = 1.1f;
		
		readonly IInput input;
		readonly Player player;
		float totalDistance;
		float time;

		public WalkState(IInput input, Player player) {
			this.input = input;
			this.player = player;
		}

		public void OnEnter() {
			totalDistance = 0;
			time = 0;
		}

		public State Update(float deltaTime) {
			time += deltaTime;

			if (input.IsForwardButtonDown()) {
				var distance = Speed * deltaTime;
				totalDistance += distance;
				player.Forward(distance);
				
				// 適当に進んだらゴールってことにする
				if (player.Position > 25) {
					return State.Goal;
				}

				// ちょっと進んだら適当にIdleかJumpにしとく
				if (totalDistance > 10) {
					var random = new Random().Next(0, 100);
					return random > 50 ? State.Idle : State.Jump;
				}
			}

			// 適当に時間経過でIdleに戻しちゃう
			return time > 10 ? State.Idle : State.Walk;
		}

	}

}