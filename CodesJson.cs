using System;
using System.Collections.Generic;

namespace iplr_dotnet
{
	#pragma warning disable 0649
	class TeamJson
	{
		public int id;
		public string fn, sn, abb, name, color;
	}

	class GroundJson
	{
		public int id;
		public string fn, sn, city, country, path;
	}

	class PlayerJson
	{
		public int id;
		public string fn, sn, country, path;
	}

	class CodesJson
    {
        public List<TeamJson> teams;
        public List<GroundJson> grounds;
        public List<PlayerJson> players;

        public void print()
        {
            Console.WriteLine("CodesJson object.");
            Console.WriteLine("\t---- " + teams.Count + " teams");
            Console.WriteLine("\t---- " + grounds.Count + " grounds");
            Console.WriteLine("\t---- " + players.Count + " players");
        }
    }
}
