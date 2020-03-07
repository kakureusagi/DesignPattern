using System.Numerics;

namespace Command.State {

	/// <summary>
	/// 移動状態
	/// </summary>
	class MoveState : IState {

		readonly IMovable movable;
		Vector2 destination;
		bool reached;

		public MoveState(IMovable movable) {
			this.movable = movable;
		}

		public void SetDestination(Vector2 destination) {
			this.destination = destination;
			reached = false;
		}

		public void Update(float deltaTime) {
			if (reached) {
				return;
				
			}

			// 今回の移動で到着するかどうか判定
			var direction = destination - movable.Position;
			var distance = movable.Speed * deltaTime;
			if (direction.LengthSquared() < distance * distance) {
				reached = true;
				movable.Position = destination;
				return;
			}

			movable.Position += Vector2.Normalize(direction) * distance;
		}
	}

}