using System;

namespace ChainOfResponsibility {

	class Program {
		static void Main(string[] args) {
			ResolverManager.Instance.AddResolver(new TypeAResolver());
			ResolverManager.Instance.AddResolver(new TypeBResolver());

			var originalA = new TypeA {
				A = 1,
				B = 2,
			};

			var originalB = new TypeB {
				C = 3,
				D = "4",
			};

			var serializer = new Serializer();
			serializer.SetResolver(ResolverManager.Instance);

			var jsonA = serializer.Serialize(originalA);
			Console.WriteLine(jsonA);

			var jsonB = serializer.Serialize(originalB);
			Console.WriteLine(jsonB);

			var deserializedA = serializer.Deserialize<TypeA>(jsonA);
			Console.WriteLine(deserializedA);
			var deserializedB = serializer.Deserialize<TypeB>(jsonB);
			Console.WriteLine(deserializedB);

			// Exception
			try {
				serializer.Serialize(new TypeC());
			}
			catch (Exception e) {
				Console.WriteLine(e.ToString());
			}
		}
	}

}