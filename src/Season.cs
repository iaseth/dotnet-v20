using System;
using System.Collections.Generic;

namespace V20 {
	class Season {
		public League league;
		public string year;
		public List<Match> matches;

		public Season (League league, SeasonJson jo) {
			this.league = league;
			year = jo.year;

			matches = new List<Match>();
			foreach (MatchJson mj in jo.matches) {
				Match m = new Match(this, mj);
				matches.Add(m);
			}
		}

		public void print () {
			Console.WriteLine($"Season: {year} ({matches.Count} matches)");
		}
	}
}