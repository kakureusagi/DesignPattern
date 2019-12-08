namespace Facade.System.RouteSubSystem {

	/// <summary>
	/// Viewで必要なURLなどを生成する
	/// </summary>
	class UrlCreator {

		readonly string root;


		public UrlCreator(string root) {
			this.root = root;
		}

		public string GetUrl(string api) {
			return $"{root}/{api}";
		}
	}

}