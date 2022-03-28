using System;

namespace V20 {
	class Player {
		League league;
		PlayerJson jo;
		int id;
		string fn, sn, path, country;

		public Player(League league, PlayerJson jo) {
			this.league = league;
			this.jo = jo;
			id = jo.id;
			fn = jo.fn; sn = jo.sn;
			path = jo.path; country = jo.country;
		}

		public void print() {
			Console.WriteLine($"Player: {sn} ({country})");
		}
	}
}