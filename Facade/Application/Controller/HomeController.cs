using System;
using Facade.System;

namespace Facade.Application.Controller {

	class HomeController : IController {

		public void Index() {
			var urlName = Route.View("home");
			Console.WriteLine(urlName);
		}

	}

}