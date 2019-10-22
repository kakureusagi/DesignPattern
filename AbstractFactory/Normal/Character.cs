namespace AbstractFactory {

	/// <summary>
	/// 本番用のキャラクター制御
	/// </summary>
	class Character : Positionable, ICharacter {

		readonly Animator animator;


		public Character(Animator animator, int width, int height, int cost) : base(width, height, cost) {
			this.animator = animator;
		}

		public void StartWalkAnimation() {
			animator.Start("Walk");
		}
	}

}