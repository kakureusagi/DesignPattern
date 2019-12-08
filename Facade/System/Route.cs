using Facade.System.RouteSubSystem;

namespace Facade.System {

	/// <summary>
	/// アプリケーションフレームワークを使う人が使う
	/// </summary>
	static class Route {

		static ControllerResolver resolver;
		static UrlCreator urlCreator;

		public static void Initialize(RouteSettings settings) {
			resolver = new ControllerResolver();
			urlCreator = new UrlCreator(settings.RootUrl);
		}

		public static string View(string api) {
			return urlCreator.GetUrl(api);
		}

		public static void Bind(string api, string controllerName) {
			resolver.Bind(api, controllerName);
		}

		public static IController Resolve(string api) {
			return resolver.Resolve(api);
		}


	}

}