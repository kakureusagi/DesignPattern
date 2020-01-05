namespace Observer {

	/// <summary>
	/// アプリケーションレベルの通信処理を担当するApplicationHttpの生成を担当する
	/// </summary>
	interface IApplicationHttpFactory {
		IApplicationHttp Create();
	}

	class ApplicationHttpFactory : IApplicationHttpFactory {

		public static readonly ApplicationHttpFactory Instance = new ApplicationHttpFactory();


		IUserObserver observer;


		public void SetUserDataObserver(IUserObserver observer) {
			this.observer = observer;
		}

		public IApplicationHttp Create() {
			var http = new ApplicationHttp();
			http.AddObserver(observer);

#if DEBUG
			http.AddObserver(new UserLogger());
#endif

			return http;
		}
	}

}