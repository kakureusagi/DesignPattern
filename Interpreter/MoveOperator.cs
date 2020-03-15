namespace Interpreter {

	/// <summary>
	/// キャラクターの移動オペレータ
	/// </summary>
	class MoveOperator : IOperator {

		readonly CharacterManager manager;

		public MoveOperator(CharacterManager manager) {
			this.manager = manager;
		}

		public void Execute(OperationParameter parameter) {
			var x = int.Parse(parameter[2]);
			var y = int.Parse(parameter[3]);
			manager.Move(parameter[1], x, y);
		}
	}

}