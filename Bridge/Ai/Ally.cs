namespace Bridge {

	/// <summary>
	/// 味方
	/// </summary>
	class Ally : AiBase {

		public Ally(ICharacter character) : base(character) {
		}

		public override void Think() {
			// プレイヤーについてまわる
			character.Walk();
		}
	}

}