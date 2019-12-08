using Facade.System.RouteSubSystem;

namespace Facade.System {

	class Framework {

		public static void Initialize() {
			Route.Initialize(new RouteSettings {
				DocumentRoot = "/var/www/html",
				RootUrl = "https://kakureusagi.com",
			});
		}
	}

}