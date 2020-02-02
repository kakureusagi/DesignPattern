using System;

namespace State {

	class IdleState : IState {

		readonly IInput input;

		public IdleState(IInput input) {
			this.input = input;
		}

		public void OnEnter() {
		}

		public State Update(float deltaTime) {
			// Idle時はどこにでも遷移する
			if (input.IsDashButtonDown()) {
				return State.Idle;
			}

			if (input.IsForwardButtonDown()) {
				return State.Walk;
			}

			if (input.IsJumpButtonDown()) {
				return State.Jump;
			}

			return State.Idle;
		}

	}

}