using System;
using System.Collections.Generic;

namespace V20 {
	class League {
		CodesJson cj;
		BundleJson bj;

		List<Team> teams;
		List<Ground> grounds;
		List<Player> players;

		List<Season> seasons;
		List<Match> matches;

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
			players = new List<Player>();
			foreach (PlayerJson jo in cj.players) {
				Player player = new Player(this, jo);
				players.Add(player);
			}
		}


		public void loadBundle(BundleJson bj) {
			this.bj = bj;
			seasons = new List<Season>();
			matches = new List<Match>();
			foreach (SeasonJson jo in bj.seasons) {
				Season s = new Season(this, jo);
				seasons.Add(s);
			}
		}


		public void doStuff() {
			printSeasons();
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

		public void printPlayers() {
			foreach (Player player in players) {
				player.print();
			}
		}


		public void printSeasons() {
			foreach (Season s in seasons) {
				s.print();
			}
		}


		public void print() {
			//
		}
	}
}