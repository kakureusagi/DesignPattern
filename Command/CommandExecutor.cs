using System.Collections.Generic;

namespace Command {

	/// <summary>
	/// コマンドの実行管理
	/// </summary>
	class CommandExecutor {

		private readonly List<CommandBase> commands = new List<CommandBase>();

		public void OnReceiveCommand(CommandBase command) {
			commands.Add(command);
		}
		
		public void Update(float deltaTime) {
			for (var i = 0; i < commands.Count; ) {
				CommandBase command = commands[i];
				command.ExecuteTime -= deltaTime;
				
				if (command.ExecuteTime <= 0) {
					command.Execute();
					commands.RemoveAt(i);
					continue;
				}

				++i;
			}
		}
		
	}

}