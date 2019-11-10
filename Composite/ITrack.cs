namespace Composite {

	/// <summary>
	/// トラック
	/// </summary>
	interface ITrack {

		string Name { get; set; }

		/// <summary>
		/// トラックが有効かどうか
		/// </summary>
		bool IsEnabled { get; set; }

		/// <summary>
		/// トラックを評価する
		/// </summary>
		/// <param name="time"></param>
		void Evaluate(float time);
	}

}