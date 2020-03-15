namespace Interpreter {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static void Main(string[] args) {
			//
			// 解決したい問題
			// エンジニアが作業することなく、キャラクターのアニメーションなどの調整を早いイテレーションで実行したい
			// ↓
			// 独自のスクリプト言語の実装で解消
			
			var text = @"
character kuma kuma.png
character usagi usagi.png

move kuma 50 0
move usagi 20 100
";

			var parser = new Parser();
			var parameters = parser.Parse(text);

			var manager = new CharacterManager();
			var executor = new OperatorExecutor(manager);
			executor.Execute(parameters);
		}
	}

}