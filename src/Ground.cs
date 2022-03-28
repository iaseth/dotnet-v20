using System;

namespace V20 {
	class Ground {
		League league;
		GroundJson jo;
		int id;
		string fn, sn, path, city, country;

		public Ground(League league, GroundJson jo) {
			this.league = league;
			this.jo = jo;
			id = jo.id;
			fn = jo.fn; sn = jo.sn; path = jo.path;
			city = jo.city; country = jo.country;
		}

		public void print() {
			Console.WriteLine($"Ground: {sn} ({city}, {country})");
		}
	}
}