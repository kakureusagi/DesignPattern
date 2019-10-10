namespace Prototype {

	/// <summary>
	/// UnityのTransformっぽいクラス.
	/// </summary>
	class Transform {

		public GameObject GameObject { get; set; }

		public float Position { get; set; }
		public float Rotation { get; set; }
		public float Scale { get; set; }

		public Transform Instantiate(GameObject gameObject) {
			Transform clone = MemberwiseClone() as Transform;
			clone.GameObject = gameObject;
			return clone;
		}

	}

}