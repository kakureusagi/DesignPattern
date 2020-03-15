namespace Interpreter {

	/// <summary>
	/// １つ１つのパラメータの実行者
	/// </summary>
	interface IOperator {
		void Execute(OperationParameter parameter);
	}

}