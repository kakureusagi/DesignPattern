namespace Strategy {

	/// <summary>
	/// ユーザーの装備するカード情報.
	/// </summary>
	class Card {
		public int Id { get; set; }
		public bool IsEquipped { get; set; }

		public override string ToString() {
			return $"{nameof(Id)}: {Id}, {nameof(IsEquipped)}: {IsEquipped}";
		}
	}

}