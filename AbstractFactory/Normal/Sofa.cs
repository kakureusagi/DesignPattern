namespace AbstractFactory {

	/// <summary>
	/// 本番用のソファ
	/// </summary>
	class Sofa : Positionable, ISofa {

		readonly Animator animator;
		ICharacter character;

		public Sofa(Animator animator, int width, int height, int cost) : base(width, height, cost) {
			this.animator = animator;
		}

		public void StartIdleAnimation() {
			animator.Start("Idle");
		}
	}

}