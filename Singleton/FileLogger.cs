using System;

namespace Singleton {

	/// <summary>
	/// ファイルにログを記録する
	/// </summary>
	sealed class FileLogger : ILogger, IDisposable {

		public static FileLogger Instance { get; } = new FileLogger();

		private string rootPath;


		private FileLogger() {
		}

		public void SetRootPath(string rootPath) {
			this.rootPath = rootPath;
		}

		public void Dispose() {
			if (rootPath != null) {
				Console.WriteLine("ここでStreamを解放するとする");
				rootPath = null;
			}
		}


		void ILogger.LogMessage(string message) {
			// 排他制御が必要になりそう
			Console.WriteLine($"RootPath: {rootPath}, Message: {message}");
		}

		void ILogger.LogWarning(string message) {
			// 排他制御が必要になりそう
			Console.WriteLine($"RootPath: {rootPath}, Warning: {message}");
		}

		void ILogger.LogError(string message) {
			// 排他制御が必要になりそう
			Console.WriteLine($"RootPath: {rootPath}, Error: {message}");
		}

	}

}