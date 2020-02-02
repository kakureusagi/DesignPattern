namespace State {

	class Player {
		
		public float Position { get; private set; }

		public void Forward(float distance) {
			Position += distance;
		}
	}

}