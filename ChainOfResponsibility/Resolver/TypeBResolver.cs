namespace ChainOfResponsibility {


	class TypeBResolver : IResolver {

		readonly TypeBJsonFormatter formatter = new TypeBJsonFormatter();

		public IJsonFormatter<T> GetFormatter<T>() {
			if (typeof(T) == typeof(TypeB)) {
				return (IJsonFormatter<T>)formatter;
			}

			return null;
		}
	}

}