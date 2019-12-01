namespace ChainOfResponsibility {


	interface IResolver {

		IJsonFormatter<T> GetFormatter<T>();

	}

}