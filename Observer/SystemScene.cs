using System;

namespace Observer {

	/// <summary>
	/// アプリケーションの寿命の間存続し続けるシーン
	/// </summary>
	class SystemScene : IUserObserver {

		public void Run() {
			ApplicationHttpFactory.Instance.SetUserDataObserver(this);
		}

		void IUserObserver.OnUserDataChanged(User user) {
			// ここでメモリに保持し続けているUserデータを更新したりする
			Console.WriteLine($"[{nameof(SystemScene)}] UserId:{user.Id}");
		}
	}

}