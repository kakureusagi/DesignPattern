namespace Singleton {

	/// <summary>
	/// ログクラス使う人
	/// </summary>
	class UseCase {

		// シングルトンに依存させないこと
		private readonly ILogger logger;


		public UseCase(ILogger logger) {
			this.logger = logger;
		}

		public void Run() {
			logger.LogMessage("処理が終わったよ");
			logger.LogWarning("Missingが発生してます！");
			logger.LogError("ヌルポ！！");
		}

	}

}