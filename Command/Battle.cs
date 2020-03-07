namespace Command {

	/// <summary>
	/// RTSのバトル全体管理クラス
	/// </summary>
	class Battle {
		
		readonly CommandExecutor executor;
		readonly Fighter fighter;

		
		public Battle(CommandExecutor executor, Fighter fighter) {
			this.executor = executor;
			this.fighter = fighter;
		}

		public void Update(float deltaTime) {
			executor.Update(deltaTime);
			fighter.Update(deltaTime);
		}
	}

}