namespace Interpreter {

	/// <summary>
	/// オペレーションのパラメータ
	/// </summary>
	class OperationParameter {

		public string Name => parameters[0];

		readonly string[] parameters;

		public OperationParameter(string[] parameters) {
			this.parameters = parameters;
		}

		public string this[int i] => parameters[i];
	}

}