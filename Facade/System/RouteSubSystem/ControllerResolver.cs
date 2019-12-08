using System;
using System.Collections.Generic;

namespace Facade.System.RouteSubSystem {

	/// <summary>
	/// HTTPリクエストに応じて必要なコントローラーを作成する人
	/// </summary>
	public class ControllerResolver {

		readonly Dictionary<string, Type> controllers = new Dictionary<string, Type>();

		public void Bind(string api, string controllerName) {
			controllers.Add(api, Type.GetType(controllerName));
		}

		public IController Resolve(string api) {
			var instance = Activator.CreateInstance(controllers[api]);
			return instance as IController;
		}

	}

}