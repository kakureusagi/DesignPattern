namespace Bridge {

	/// <summary>
	/// NPC
	/// </summary>
	class Npc : AiBase {

		public Npc(ICharacter character) : base(character) {
		}

		public override void Think() {
			// ずっとIdle.
			character.Idle();
		}
	}

}