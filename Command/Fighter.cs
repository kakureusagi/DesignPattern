using System.Numerics;
using Command.State;

namespace Command {

	/// <summary>
	/// ゲーム中のキャラクター
	/// </summary>
	class Fighter : IMoveCommandReceiver, IMovable {
		
		public Vector2 Position { get; set; }
		public float Speed { get; } = 1;
		IState state = new NullState();
		
		public void OnMoveCommand(Vector2 destination) {
			var moveState = new MoveState(this);
			moveState.SetDestination(destination);
			state = moveState;
		}

		public void Update(float deltaTime) {
			state.Update(deltaTime);
		}
	}

}