using System;
using System.IO;

using Newtonsoft.Json;

namespace V20
{
	class Program
	{
		static void Main(string[] args)
		{
			League league;
			using (StreamReader file = File.OpenText(@"data/codes.json")) {
				JsonSerializer js = new JsonSerializer();
				CodesJson cj = (CodesJson)js.Deserialize(file, typeof(CodesJson));
				league = new League(cj);
			}

			using (StreamReader file = File.OpenText(@"data/bundle.json")) {
				JsonSerializer js = new JsonSerializer();
				BundleJson bj = (BundleJson)js.Deserialize(file, typeof(BundleJson));
				league.loadBundle(bj);
			}

			league.doStuff();
		}
	}
}
