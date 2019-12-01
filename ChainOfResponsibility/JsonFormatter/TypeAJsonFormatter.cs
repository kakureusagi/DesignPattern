namespace ChainOfResponsibility {

	class TypeAJsonFormatter : IJsonFormatter<TypeA> {

		public string Serialize(TypeA value) {
			return $"{{\"A\":{value.A},\"B\":{value.B}}}";
		}

		public TypeA Deserialize(string json) {
			return new TypeA {
				A = json[5] - '0',
				B = json[11] - '0',
			};
		}
	}

}