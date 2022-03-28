using System;

namespace V20 {
	class Team {
		League league;
		TeamJson jo;

		int id;
		string fn, sn, abb, path;

		public Team(League league, TeamJson jo) {
			this.league = league;
			this.jo = jo;
			id = jo.id;
			fn = jo.fn; sn = jo.sn; abb = jo.abb;
		}

		public void print() {
			Console.WriteLine("Team: " + fn + " (" + abb + ")");
		}
	}
}