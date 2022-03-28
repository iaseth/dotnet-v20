using System;
using System.Collections.Generic;

namespace V20 {
	class League {
		CodesJson cj;
		BundleJson bj;

		List<Team> teams;
		List<Ground> grounds;

		public League(CodesJson cj) {
			this.cj = cj;
			setupTeams(); setupGrounds(); setupPlayers();
		}

		public void setupTeams() {
			teams = new List<Team>();
			foreach (TeamJson jo in cj.teams) {
				Team team = new Team(this, jo);
				teams.Add(team);
			}
		}

		public void setupGrounds() {
			grounds = new List<Ground>();
			foreach (GroundJson jo in cj.grounds) {
				Ground ground = new Ground(this, jo);
				grounds.Add(ground);
			}
		}

		public void setupPlayers() {
			//
		}


		public void loadBundle(BundleJson bj) {
			this.bj = bj;
		}

		public void doStuff() {
			// printTeams();
			printGrounds();
		}


		public void printTeams() {
			foreach (Team team in teams) {
				team.print();
			}
		}

		public void printGrounds() {
			foreach (Ground ground in grounds) {
				ground.print();
			}
		}


		public void print() {
			//
		}
	}
}