using System;

namespace Prototype {

	/// <summary>
	/// エントリーポイント
	/// </summary>
	class Program {

		static void Main(string[] args) {
			var original = new GameObject("Test");
			original.AddComponent();
			original.Transform.Position = 1;
			original.Transform.Rotation = 2;
			original.Transform.Scale = 3;

			var clone = original.Instantiate();
			clone.Transform.Position = 11;
			clone.Transform.Rotation = 22;
			clone.Transform.Scale = 33;

			Console.WriteLine($"GameObject name are {original.Name} and {clone.Name}.");
			Console.WriteLine($"Original component is not equal. Result: {original.Components[0] == clone.Components[0]}.");
			Console.WriteLine($"Original transform is [{original.Transform.Position}, {original.Transform.Rotation}, {original.Transform.Scale}].");
			Console.WriteLine($"Clone transform is [{clone.Transform.Position}, {clone.Transform.Rotation}, {clone.Transform.Scale}].");
		}

	}

}