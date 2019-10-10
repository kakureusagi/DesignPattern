using System;

namespace Prototype {

	/// <summary>
	/// UnityのGameObjectっぽいクラス.
	/// </summary>
	class GameObject {

		public string Name { get; set; }
		public Transform Transform { get; private set; }
		public Component[] Components { get; private set; }


		public GameObject(string name) {
			Name = name;
			Transform = new Transform();
		}

		public Component AddComponent() {
			if (Components == null) {
				Components = new Component[1];
			}
			else {
				Component[] newComponents = new Component[Components.Length + 1];
				Array.Copy(Components, newComponents, Components.Length);
				Components = newComponents;
			}

			Component component = new Component {
				GameObject = this,
				Transform = Transform,
			};

			Components[Components.Length - 1] = component;

			return component;
		}


		public GameObject Instantiate() {
			// 実際には階層構造そのものをコピーする必要があるため、再帰的に処理をする必要があるけど、今回は1段階しかない想定.
			var cloneGameObject = MemberwiseClone() as GameObject;

			// コピーしたTransformやComponentの参照を適切に設定する.
			cloneGameObject.Name = Name + "(Clone)";
			cloneGameObject.Transform = Transform.Instantiate(cloneGameObject);
			if (cloneGameObject.Components != null) {
				cloneGameObject.Components = new Component[Components.Length];
				for (var i = 0; i < cloneGameObject.Components.Length; i++) {
					var cloneComponent = Components[i].Instantiate(cloneGameObject);
					cloneGameObject.Components[i] = cloneComponent;
				}
			}

			return cloneGameObject;
		}

	}

}