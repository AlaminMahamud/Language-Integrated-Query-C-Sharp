// Use into to create a continuation

using System;
using System.Linq;

class IntoDemo
{
	static void Main(string[] args)
	{
		string[] websites = {
							 "hasNameA.com", 
							 "hasNameB.net", 
							 "hasNameC.org",
							 "hasNameD.com", 
							 "hasNameE.net", 
							 "hasNameF.org"
							};

		// Create a query that groups websites by top-level domain name
		// but select only those groups that have more than two members
		// Here ws is the range variable over the set of groups
		// returned when the first half of the query is executed

		var webAddress = from s in websites
						 where s.LastIndexOf('.') !=-1
						 group s by s.Substring(s.LastIndexOf('.'))
						 	into ws
						 where ws.Count()>2
						 select ws;

		// Execute the query and display the results
		Console.WriteLine("Top-Level Domain with more than 2 members");

		foreach(var sites in webAddress)
		{
			Console.WriteLine("Contents of " + sites.Key + " domain:");
			foreach(var sites in webAddrs)
				Console.WriteLine(" "+site);
			Console.WriteLine();
		}

	}
}



