namespace TemplateMethod {

	/// <summary>
	/// 適当な3Dのモデル情報
	/// </summary>
	public class Model {

		public byte[] Mesh { get; }

		public Model(byte[] mesh) {
			Mesh = mesh;
		}

	}

}