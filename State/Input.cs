namespace State {

	class Input : IInput {

		bool isDashButton;
		bool isJumpButton;
		bool isFowardButton;

		public bool IsDashButtonDown() {
			return isDashButton;
		}

		public bool IsJumpButtonDown() {
			return isJumpButton;
		}

		public bool IsForwardButtonDown() {
			return isFowardButton;
		}

		public void SetDashButton(bool down) {
			isDashButton = down;
		}

		public void SetJumpButton(bool down) {
			isJumpButton = down;
		}

		public void SetForwardButton(bool down) {
			isFowardButton = down;
		}
	}

}