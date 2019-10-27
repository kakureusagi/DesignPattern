namespace Bridge {

	/// <summary>
	/// モンスター
	/// </summary>
	class Monster : AiBase {

		bool isIdle;

		public Monster(ICharacter character) : base(character) {
		}

		public override void Think() {
			// プレイヤーが近くにいたら攻撃、離れたらその場で待機する
			// 今回は雑に適当に攻撃と待機を繰り返すこととします
			if (isIdle) {
				character.Attack();
				isIdle = false;
			}
			else {
				character.Idle();
				isIdle = true;
			}
		}
	}

}