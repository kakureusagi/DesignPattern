namespace ChainOfResponsibility {

	public class TypeB {
		public int C { get; set; }
		public string D { get; set; }

		public override string ToString() {
			return $"{nameof(C)}: {C}, {nameof(D)}: {D}";
		}
	}

}