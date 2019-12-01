namespace ChainOfResponsibility {

	class TypeAResolver : IResolver {

		readonly TypeAJsonFormatter formatter = new TypeAJsonFormatter();

		public IJsonFormatter<T> GetFormatter<T>() {
			if (typeof(T) == typeof(TypeA)) {
				return (IJsonFormatter<T>)formatter;
			}

			return null;
		}
	}

}