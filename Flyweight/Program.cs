using System;
using System.Threading.Tasks;

namespace Flyweight {

	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {
		static async Task Main(string[] args) {
			var catalog = new Catalog() {
				Size = 9,
				Items = new Item[] {
					new Item {
						Path = "abc",
						Size = 3,
					},
					new Item {
						Path = "def",
						Size = 6,
					}
				}
			};

			var loader = new AssetBundleLoader(catalog);

			var abcBundle = await loader.GetAssetBundle("abc");
			Console.WriteLine(abcBundle.GetTexture());

			var defBundle = await loader.GetAssetBundle("def");
			Console.WriteLine(defBundle.GetTexture());
		}
	}

}