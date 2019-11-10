namespace Composite {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static void Main(string[] args) {
			var builder = new Builder();
			var director = new Director();

			// compositeなTrack
			director.Run(builder.CreateTimeline());

			// singleなTrack
			director.Run(builder.CreateTrack());
		}
	}

}