namespace State {

	class NullState : IState {

		public void OnEnter() {
		}

		public State Update(float deltaTime) {
			return State.None;
		}
	}

}