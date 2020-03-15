namespace Interpreter {

	/// <summary>
	/// キャラクター生成オペレータ
	/// </summary>
	class CharacterOperator : IOperator {

		readonly CharacterManager manager;

		public CharacterOperator(CharacterManager manager) {
			this.manager = manager;
		}

		public void Execute(OperationParameter parameter) {
			var id = parameter[1];
			var texture = parameter[2];
			manager.Create(id, texture);
		}
	}

}