namespace State {

	interface IState {

		/// <summary>
		/// Stateがこのクラス制御に切り替わったときに呼ばれる
		/// </summary>
		void OnEnter();
		
		/// <summary>
		/// 毎フレーム呼ばれる
		/// </summary>
		State Update(float deltaTime);
	}

}