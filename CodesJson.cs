using System;
using System.Collections.Generic;

namespace iplr_dotnet
{
	#pragma warning disable 0649
	class TeamJson
	{
		public int id;
		public string fn, sn, abb, name, color;

		public void print()
		{
			Console.WriteLine("Team: " + fn + " (" + abb + ")");
		}
	}

	class GroundJson
	{
		public int id;
		public string fn, sn, city, country, path;

		public void print()
		{
			Console.WriteLine("Ground: " + fn + " (" + city + ")");
		}
	}

	class PlayerJson
	{
		public int id;
		public string fn, sn, country, path;

		public void print()
		{
			Console.WriteLine("Player: " + fn + " (" + country + ")");
		}
	}

	class CodesJson
	{
		public List<TeamJson> teams;
		public List<GroundJson> grounds;
		public List<PlayerJson> players;

		public void printTeams()
		{
			foreach (var team in teams) team.print();
		}

		public void printGrounds()
		{
			foreach (var ground in grounds) ground.print();
		}

		public void printPlayers()
		{
			foreach (var player in players) player.print();
		}

		public void print()
		{
			Console.WriteLine("CodesJson object.");
			Console.WriteLine("\t---- " + teams.Count + " teams");
			Console.WriteLine("\t---- " + grounds.Count + " grounds");
			Console.WriteLine("\t---- " + players.Count + " players");
		}
	}
}
