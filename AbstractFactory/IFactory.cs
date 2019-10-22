namespace AbstractFactory {

	/// <summary>
	/// ハコニワのオブジェクト生成ファクトリ
	/// </summary>
	public interface IFactory {

		ISofa CreateSofa(int id);

		ICharacter CreateCharacter(int id);
	}

}