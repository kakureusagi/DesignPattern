namespace Command.State {

	/// <summary>
	/// キャラクターなどの状態
	/// </summary>
	interface IState {

		void Update(float deltaTime);
	}

}