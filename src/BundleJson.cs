using System;
using System.Collections.Generic;

namespace IplrDotnet
{
	// disables warning that field is never assigned to
	#pragma warning disable 0649

	class MatchJson {
		//

		public void print() {
			Console.WriteLine("Match object {}");
		}
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

		public void printFirstMatch() {
			seasons[0].matches[0].print();
		}

		public void print() {
			foreach (var season in seasons) {
				season.print();
			}
		}
	}
}