namespace State {

	class GoalState : IState {
		
		public void OnEnter() {
			// バンザイとかするとする
		}

		public State Update(float deltaTime) {
			return State.Goal;
		}
	}

}