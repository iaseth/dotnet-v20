using System;
using System.Collections.Generic;

namespace V20 {
	class League {
		CodesJson cj;
		BundleJson bj;

		List<Team> teams;

		public League(CodesJson cj) {
			this.cj = cj;
			setupTeams();
		}

		public void setupTeams() {
			teams = new List<Team>();
			foreach (TeamJson jo in cj.teams) {
				Team team = new Team(this, jo);
				teams.Add(team);
			}
		}

		public void loadBundle(BundleJson bj) {
			this.bj = bj;
		}

		public void doStuff() {
			printTeams();
		}


		public void printTeams() {
			foreach (Team team in teams) {
				team.print();
			}
		}


		public void print() {
			//
		}
	}
}