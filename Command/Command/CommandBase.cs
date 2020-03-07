namespace Command {

	/// <summary>
	/// コマンドの基本クラス
	/// </summary>
	abstract class CommandBase : ICommand {

		public float ExecuteTime { get; set; }

		public abstract void Execute();
	}

}