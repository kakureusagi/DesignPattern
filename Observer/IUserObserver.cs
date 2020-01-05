namespace Observer {

	/// <summary>
	/// ユーザーデータの観測者
	/// </summary>
	interface IUserObserver {
		void OnUserDataChanged(User user);
	}

}