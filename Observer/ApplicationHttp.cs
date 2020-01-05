using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Observer {

	/// <summary>
	/// 通信を行って、アプリケーションのルールに沿った処理をする
	/// </summary>
	interface IApplicationHttp {
		Task<ApplicationHttpResponse> GetAsync();
	}

	class ApplicationHttp : IApplicationHttp {

		readonly List<IUserObserver> observers = new List<IUserObserver>();

		public void AddObserver(IUserObserver observer) {
			observers.Add(observer);
		}

		public async Task<ApplicationHttpResponse> GetAsync() {
			var http = new Http();
			var json = await http.GetAsync();

			var response = JsonConvert.DeserializeObject<ApplicationHttpResponse>(json);

			foreach (var observer in observers) {
				observer.OnUserDataChanged(response.User);
			}

			return response;
		}

	}

}