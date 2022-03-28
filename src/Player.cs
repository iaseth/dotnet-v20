using System;
using System.Collections.Generic;

namespace V20 {
	class Player {
		League league;
		PlayerJson jo;
		public int id;
		string fn, sn, path, country;

		public Player (League league, PlayerJson jo) {
			this.league = league;
			this.jo = jo;
			id = jo.id;
			fn = jo.fn; sn = jo.sn;
			path = jo.path; country = jo.country;
		}

		public void print () {
			Console.WriteLine($"Player #{id}: {fn} ({country})");
		}
	}

	class PlayerComparer : IComparer<Player> {
		public int Compare (Player p1, Player p2) {
			return (p1.id - p2.id);
		}
	}
}