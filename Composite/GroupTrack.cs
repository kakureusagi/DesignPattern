using System;
using System.Collections.Generic;

namespace Composite {

	/// <summary>
	///　子供を持てるTrack
	/// </summary>
	class GroupTrack : ITrack {

		readonly List<ITrack> children = new List<ITrack>();

		public string Name { get; set; }

		public bool IsEnabled { get; set; } = true;


		public void Evaluate(float time) {
			if (!IsEnabled) {
				return;
			}

			Console.WriteLine($"{nameof(GroupTrack)} {nameof(Name)}:{Name}");
			foreach (var child in children) {
				child.Evaluate(time);
			}
		}

		public void Add(ITrack child) {
			children.Add(child);
		}

		public void Remove(ITrack child) {
			children.Remove(child);
		}
	}

}