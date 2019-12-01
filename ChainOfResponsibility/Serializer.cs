namespace ChainOfResponsibility {

	class Serializer {

		IResolver resolver;


		public void SetResolver(IResolver resolver) {
			this.resolver = resolver;
		}


		public string Serialize<T>(T value) {
			return resolver.GetFormatter<T>().Serialize(value);
		}

		public T Deserialize<T>(string json) {
			return resolver.GetFormatter<T>().Deserialize(json);
		}

	}

}