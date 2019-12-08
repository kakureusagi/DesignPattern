using System;
using Facade.System;

namespace Facade.Application.Controller {

	class BattleController : IController {

		public void Index() {
			var urlName = Route.View("battle");
			Console.WriteLine(urlName);
		}
	}

}