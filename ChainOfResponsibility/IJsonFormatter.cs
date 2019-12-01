namespace ChainOfResponsibility {

	interface IJsonFormatter<T> {

		string Serialize(T value);
		T Deserialize(string json);

	}

}