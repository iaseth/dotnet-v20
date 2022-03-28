using System;
using System.Collections.Generic;

namespace IplrDotnet
{
	// disables warning that field is never assigned to
	#pragma warning disable 0649

	class OverJson {
		public int over;
		public List<string> balls;
	}

	class WicketJson {
		public int id, ball, over, r, w;
	}

	class ExtrasJson {
		public int b, lb, nb, p, wd;
	}

	class TeamInningJson {
		public int runs, balls;
		public string overs;
		public ExtrasJson extras;
		public List<WicketJson> wickets;
		public List<OverJson> history;

		public void print() {
			Console.WriteLine(runs + " (" + overs + ")");
			Console.WriteLine(wickets.Count + " wickets.");
			Console.WriteLine(history.Count + " overs.");
		}
	}

	class SquadJson {
		public int team, captain, wk;
		public List<int> players;

		public void print() {
			Console.WriteLine("Team: " + team);
			Console.WriteLine(" Cap: " + captain);
			Console.WriteLine("  Wk: " + wk);

			Console.Write("Team: [ ");
			foreach (int p in players) Console.Write(p + " ");
			Console.WriteLine("]\n");
		}
	}

	class MatchMetaJson {
		public int ground, number;
		public string outcome, state, year;
		public List<int> order;

		public void print() {
			Console.WriteLine(" Ground: " + ground);
			Console.WriteLine(" Number: " + number);
			Console.WriteLine("  State: " + state);
			Console.WriteLine("Outcome: " + outcome);
			Console.WriteLine("   Year: " + year);
			Console.WriteLine("  Order: " + order);
		}
	}

	class MatchJson {
		public MatchMetaJson meta;
		public List<SquadJson> teams;
		public List<TeamInningJson> innings;

		public void print() {
			Console.WriteLine("Match object {}");
			foreach (var inning in innings) inning.print();
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