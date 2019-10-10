namespace Prototype {

	/// <summary>
	/// Unityのコンポーネントっぽいクラス.
	/// </summary>
	class Component {

		public GameObject GameObject { get; set; }
		public Transform Transform { get; set; }

		public Component Instantiate(GameObject parent) {
			Component clone = MemberwiseClone() as Component;
			clone.GameObject = parent;
			clone.Transform = parent.Transform;
			return clone;
		}

	}

}