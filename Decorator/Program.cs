using System.Threading.Tasks;

namespace Decorator {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {

		static async Task Main(string[] args) {
			// リリース版
			var releaseRepository = new ReleaseRepository();
			await new UseCase(releaseRepository).Run();

			// デバッグ版
			var debugger = new Debugger();
			var debuggerRepository = new DebuggerRepository(new ReleaseRepository(), debugger);
			var debugUseCase = new UseCase(debuggerRepository);

			// デバッグOFF
			await debugUseCase.Run();

			// デバッグON
			debugger.IsPurchaseDebugEnabled = true;
			debugger.ErrorCode = 1300;
			await debugUseCase.Run();
		}

	}

}