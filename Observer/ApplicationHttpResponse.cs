namespace Observer {

	/// <summary>
	/// アプリケーション側で扱えるデータ構造
	/// </summary>
	class ApplicationHttpResponse {

		public User User { get; set; }
		public SceneData Data { get; set; }

		public override string ToString() {
			return $"{nameof(User)}: {User}, {nameof(Data)}: {Data}";
		}
	}

}