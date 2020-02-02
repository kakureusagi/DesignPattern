namespace State {

	class JumpState : IState {

		float time;

		public void OnEnter() {
			time = 0;
			// 足元に土煙を出したり
		}

		public State Update(float deltaTime) {
			// ジャンプ中は何も制御できないとする
			time += deltaTime;
			return time > 10 ? State.Idle : State.Jump;
		}

	}

}