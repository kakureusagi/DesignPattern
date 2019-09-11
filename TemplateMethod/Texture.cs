namespace TemplateMethod {

	/// <summary>
	/// 適当なテクスチャ情報.
	/// </summary>
	public class Texture {

		/// <summary>
		/// 画像の幅
		/// </summary>
		public uint Width { get; }

		/// <summary>
		/// 画像の高さ
		/// </summary>
		public uint Height { get; }

		/// <summary>
		/// ピクセル情報
		/// </summary>
		public byte[] Pixels { get; }

		public Texture(uint width, uint height, byte[] pixels) {
			Width = width;
			Height = height;
			Pixels = pixels;
		}

	}

}