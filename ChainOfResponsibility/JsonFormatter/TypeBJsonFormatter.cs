namespace ChainOfResponsibility {

	class TypeBJsonFormatter : IJsonFormatter<TypeB> {

		public string Serialize(TypeB value) {
			return $"{{\"C\":{value.C},\"B\":\"{value.D}\"}}";
		}

		public TypeB Deserialize(string json) {
			return new TypeB {
				C = json[5] - '0',
				D = json[12].ToString(),
			};
		}
	}

}