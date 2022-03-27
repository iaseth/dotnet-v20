using System;
using System.Collections.Generic;

namespace IplrDotnet
{
	// disables warning that field is never assigned to
	#pragma warning disable 0649

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