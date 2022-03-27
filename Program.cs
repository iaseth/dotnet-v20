using System;
using System.IO;

using Newtonsoft.Json;

namespace iplr_dotnet
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader file = File.OpenText(@"data/codes.json"))
			{
				JsonSerializer js = new JsonSerializer();
				CodesJson cj = (CodesJson)js.Deserialize(file, typeof(CodesJson));
				cj.print();
			}
		}
	}
}
