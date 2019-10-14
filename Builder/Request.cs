using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder {

	class Request {

		string method;
		string url;
		string body;
		bool isKeepAlive;
		TimeSpan timeout;
		Dictionary<string, string> headers;


		private Request(string method, string url, string body, bool isKeepAlive, TimeSpan timeout, Dictionary<string, string> headers) {
			this.method = method;
			this.url = url;
			this.body = body;
			this.isKeepAlive = isKeepAlive;
			this.timeout = timeout;
			this.headers = headers;
		}

		public async Task<string> RequestAsync() {
			await Task.Delay(1);

			string headerString;
			if (headers.Any()) {
				headerString = headers
					.Select(pair => $"header-key:{pair.Key}, header-value:{pair.Value}")
					.Aggregate((b, a) => b + a);
			}
			else {
				headerString = "";
			}

			return $"url: {url}, method:{method}, body:{body}, isKeepAlive:{isKeepAlive}, timeout:{timeout}, headers:{headerString}";
		}


		public class Builder {

			string method;
			string url;
			string body;
			bool isKeepAlive;
			TimeSpan timeout = TimeSpan.FromSeconds(180);
			readonly Dictionary<string, string> headers = new Dictionary<string, string>();


			public Builder Header(string key, string value) {
				headers[key] = value;
				return this;
			}

			public Builder Url(string url) {
				this.url = url;
				return this;
			}

			public Builder Get() => Method("GET", null);

			public Builder Post(string body) => Method("POST", body);

			public Builder Delete(string body) => Method("DELETE", body);

			public Builder Put(string body) => Method("GET", body);

			public Builder KeepAlive() {
				isKeepAlive = true;
				return this;
			}

			public Builder Timeout(TimeSpan timeSpan) {
				timeout = timeSpan;
				return this;
			}

			private Builder Method(string method, string body) {
				if (this.method != null) {
					throw new InvalidOperationException("method is already set.");
				}

				this.method = method;
				this.body = body;

				return this;
			}

			public Request Build() {
				return new Request(method, url, body, isKeepAlive, timeout, headers);
			}
		}
	}

}