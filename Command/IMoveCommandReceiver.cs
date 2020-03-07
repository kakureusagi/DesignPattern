using System.Numerics;

namespace Command {

	/// <summary>
	/// 移動コマンドのレシーバー
	/// </summary>
	interface IMoveCommandReceiver {
		
		void OnMoveCommand(Vector2 destination);
	}

}