namespace Bridge {

	abstract class AiBase {

		protected readonly ICharacter character;

		protected AiBase(ICharacter character) {
			this.character = character;
		}

		public abstract void Think();
	}

}