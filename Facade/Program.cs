using Facade.Application;
using Facade.System;

namespace Facade {

	class Program {

		static void Main(string[] args) {
			Framework.Initialize();
			new Router().Run();
		}
	}

}