using System;
using System.Collections.Generic;

namespace ChainOfResponsibility {

	class ResolverManager : IResolver {

		public static ResolverManager Instance { get; } = new ResolverManager();

		readonly List<IResolver> resolvers = new List<IResolver>();


		public void AddResolver(IResolver resolver) {
			if (resolvers.Contains(resolver)) {
				throw new Exception("重複登録できないよ");
			}

			resolvers.Add(resolver);
		}

		public IJsonFormatter<T> GetFormatter<T>() {
			foreach (var resolver in resolvers) {
				var jsonFormatter = resolver.GetFormatter<T>();
				if (jsonFormatter != null) {
					return jsonFormatter;
				}
			}

			throw new Exception($"Can not resolve [{typeof(T)}] type.");
		}
	}

}