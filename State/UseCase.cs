using System;
using System.Collections.Generic;

namespace State {

	class UseCase {

		public State State => state;

		readonly Input input;
		readonly Player player;

		Dictionary<State, IState> states;
		IState updater = new NullState();
		State state = State.None;

		public UseCase(Input input, Player player) {
			this.input = input;
			this.player = player;
		}

		public void Run() {
			states = new Dictionary<State, IState> {
				{State.None, new NullState()},
				{State.Idle, new IdleState(input)},
				{State.Jump, new JumpState()},
				{State.Walk, new WalkState(input, player)},
				{State.Goal, new GoalState()},
			};

			ChangeState(State.Idle);
		}

		public void Update(float deltaTime) {
			var nextState = updater.Update(deltaTime);
			if (state != nextState) {
				ChangeState(nextState);
			}
		}

		void ChangeState(State nextState) {
			var nextUpdater = states[nextState];
			nextUpdater.OnEnter();

			state = nextState;
			updater = nextUpdater;
		}

	}

}