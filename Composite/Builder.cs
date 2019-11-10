namespace Composite {

	/// <summary>
	/// タイムライン生成者
	/// </summary>
	class Builder {

		public ITrack CreateTimeline() {
			var root = new GroupTrack {Name = "root"};

			// root直下のenabledなTrack
			var enabledMotion = new MotionTrack {Name = "enabled motion track"};
			root.Add(enabledMotion);

			// root直下のdisabledなTrack
			var disabledMotion = new MotionTrack {Name = "disabled motion track", IsEnabled = false};
			root.Add(disabledMotion);

			// rootの下のGroupTrack
			var group = new GroupTrack {Name = "group"};
			root.Add(group);

			var groupMotion_1 = new MotionTrack {Name = "motion track in group 1"};
			group.Add(groupMotion_1);

			var groupMotion_2 = new MotionTrack {Name = "motion track in group 2"};
			group.Add(groupMotion_2);

			return root;
		}

		public ITrack CreateTrack() {
			return new MotionTrack {Name = "one shot track", IsEnabled = true};
		}
	}

}