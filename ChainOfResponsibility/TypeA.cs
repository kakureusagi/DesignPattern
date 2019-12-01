namespace ChainOfResponsibility {

	public class TypeA {

		public int A;
		public int B;


		public override string ToString() {
			return $"{nameof(A)}: {A}, {nameof(B)}: {B}";
		}
	}

}