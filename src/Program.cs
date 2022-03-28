using System;
using System.IO;

using Newtonsoft.Json;

namespace Dotnet.V20
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader file = File.OpenText(@"data/codes.json")) {
				JsonSerializer js = new JsonSerializer();
				CodesJson cj = (CodesJson)js.Deserialize(file, typeof(CodesJson));
			}

			using (StreamReader file = File.OpenText(@"data/bundle.json")) {
				JsonSerializer js = new JsonSerializer();
				BundleJson bj = (BundleJson)js.Deserialize(file, typeof(BundleJson));
				bj.printFirstMatch();
			}
		}
	}
}
