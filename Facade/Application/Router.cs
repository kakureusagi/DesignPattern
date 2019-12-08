using Facade.Application.Controller;
using Facade.System;

namespace Facade.Application {

	public class Router {

		public void Run() {
			Route.Bind("home", typeof(HomeController).FullName);
			Route.Bind("battle", typeof(BattleController).FullName);

			// https:kakureusagi.com/homeにリクエストが飛んできたとする
			Route.Resolve("home").Index();

			// https:kakureusagi.com/battleにリクエストが飛んできたとする
			Route.Resolve("battle").Index();
		}
	}

}