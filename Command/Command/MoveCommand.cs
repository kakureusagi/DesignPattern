using System.Numerics;

namespace Command {

	/// <summary>
	/// 移動用のコマンド
	/// </summary>
	class MoveCommand : CommandBase {

		readonly IMoveCommandReceiver receiver;
		readonly Vector2 position;

		public MoveCommand(IMoveCommandReceiver receiver, Vector2 position) {
			this.receiver = receiver;
			this.position = position;
		}

		public override void Execute() {
			receiver.OnMoveCommand(position);
		}
	}

}