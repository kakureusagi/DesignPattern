namespace Composite {

	/// <summary>
	/// タイムライン実行者
	/// </summary>
	class Director {

		public void Run(ITrack timeline) {
			timeline.Evaluate(1.5f);
		}
	}

}