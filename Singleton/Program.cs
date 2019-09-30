using System.IO;

namespace Singleton {

	/// <summary>
	///  エントリポイント
	/// </summary>
	class Program {

		public static void Main(string[] args) {

			// プログラムの最上位とかで初期化しておく
			FileLogger.Instance.SetRootPath(Path.GetTempFileName());

			ILogger logger = FileLogger.Instance;
			new UseCase(logger).Run();

			// 必要なら解放
			FileLogger.Instance.Dispose();
		}

	}

}