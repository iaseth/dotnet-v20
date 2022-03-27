using System;
using System.Collections.Generic;

namespace IplrDotnet
{
	class MatchJson {
		//
	}

	class SeasonJson {
		public string year;
		public List<MatchJson> matches;

		public void print() {
			Console.WriteLine("Year " + year + " has " + matches.Count + " matches.");
		}
	}

	class BundleJson {
		public List<SeasonJson> seasons;

		public void print() {
			foreach (var season in seasons) {
				season.print();
			}
		}
	}
}