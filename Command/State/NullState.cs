namespace Command.State {

	/// <summary>
	/// 何もしない状態
	/// </summary>
	class NullState : IState {

		public void Update(float deltaTime) {
		}
	}

}