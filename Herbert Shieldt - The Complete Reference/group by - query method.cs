/// Demonstrate the Group By Query Method
/// This Program reworks the earliere versions that used
/// the query syntax

using System;
using System.Linq;

class GroupByDemo
{
	static void Main()
	{
		string[] websites = 
		{
			"hasNameA.com",
			"hasNameB.net",
			"hasNameC.org",
			"hasNameD.com",
			"hasNameE.net",
			"hasNameF.org",
		};


		// Use Query Method to group whether by top-level domain name
		var webAddrs = websites.Where(w=>w.LastIndexOf('.')!=-1)
		.GroupBy(x => x.LastIndexOf('.');

		// Execute the query and display the results
		foreach(var sites in webAddrs)
			Console.WriteLine("WebSites grouped by  " + sites.Key);
			foreach(var site in sites)
				Console.WriteLine(" "+ site);
			Console.WriteLine();
	}
}

