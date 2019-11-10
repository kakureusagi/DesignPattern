using System;

namespace Composite {

	/// <summary>
	/// Motionトラック
	/// </summary>
	class MotionTrack : ITrack {

		public string Name { get; set; }

		public bool IsEnabled { get; set; } = true;


		public void Evaluate(float time) {
			if (!IsEnabled) return;

			Console.WriteLine($"{nameof(MotionTrack)} {nameof(Name)}:{Name}, {nameof(time)}:{time}");
		}
	}

}