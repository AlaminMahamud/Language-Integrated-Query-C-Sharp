// Demonstrate another where clause
using System;
using System.Linq;

class WhereDemo2
{
	static void Main()
	{
		string[] strs = {".com", ".net", "hasA.com", "hasB.net"};
		
		// Create a Query that obtains Internet Addresses that 
		// end with .net
		var netAddrs = from addr in strs
					   where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
					   select addr;

		// Execute the query and display the results
	    foreach(var str in netAddrs)
	    	Console.WriteLine(str);
	}
}


