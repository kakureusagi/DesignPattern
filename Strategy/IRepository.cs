using System.Threading.Tasks;

namespace Strategy {

	/// <summary>
	/// カード銃砲の取得
	/// </summary>
	interface IRepository {
		Task<Card[]> GetCards();
	}

}