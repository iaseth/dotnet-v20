

namespace V20 {
	class League {
		CodesJson cj;
		BundleJson bj;

		public League(CodesJson cj) {
			this.cj = cj;
		}

		public void loadBundle(BundleJson bj) {
			this.bj = bj;
		}

		public void doStuff() {
			bj.printFirstMatch();
		}

		public void print() {
			//
		}
	}
}