using System.Collections.Generic;

namespace Interpreter {

	/// <summary>
	/// オペレータ実行者
	/// </summary>
	class OperatorExecutor {

		readonly CharacterManager characterManager;

		public OperatorExecutor(CharacterManager characterManager) {
			this.characterManager = characterManager;
		}

		public void Execute(OperationParameter[] parameters) {
			var operators = new Dictionary<string, IOperator> {
				{"character", new CharacterOperator(characterManager)},
				{"move", new MoveOperator(characterManager)},
			};

			foreach (var parameter in parameters) {
				operators.TryGetValue(parameter.Name, out var op);
				op.Execute(parameter);
			}
		}
	}

}