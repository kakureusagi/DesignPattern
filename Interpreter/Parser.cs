using System.Linq;
using System.Text.RegularExpressions;

namespace Interpreter {

	/// <summary>
	/// 構文解析
	/// </summary>
	class Parser {

		public OperationParameter[] Parse(string text) {
			var trimRegex = new Regex("\r|\t");

			return trimRegex.Replace(text, "")
				.Split('\n')
				.Where(line => !string.IsNullOrEmpty(line))
				.Select(line => new OperationParameter(line.Split(' ')))
				.ToArray();
		}
	}

}