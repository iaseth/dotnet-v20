using System;

namespace V20 {
	class Match {
		League league;
		Season season;

		public Match (Season season, MatchJson jo) {
			this.season = season;
			league = season.league;
		}

		public void print () {
			Console.WriteLine($"Match: (#0)");
		}
	}
}