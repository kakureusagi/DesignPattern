namespace Singleton {

	/// <summary>
	/// ログ用インターフェース.
	/// </summary>
	interface ILogger {

		void LogMessage(string message);

		void LogWarning(string message);

		void LogError(string message);

	}

}