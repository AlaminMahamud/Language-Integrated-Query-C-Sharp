// Demonstrate the group clause
using System;
using System.Linq;

class GroupDemo
{
    static void Main()
    {
        string[] websites = { "hsNameA.com", "hasNameB.net", "hasNameC.com", "hasNameD.net" };

        // Create a query that groups websites by top-level domain name
        var webAddrs = from addr in websites
                       where addr.LastIndexOf('.') != -1
                       group addr by addr.Substring(addr.LastIndexOf('.'));

        // Execute the query and display the results
        foreach (var sites in webAddrs)
        {
            Console.WriteLine("Web Sites Grouped By " + sites.Key);
            foreach (var site in sites)
                Console.WriteLine(" " + site);
            Console.WriteLine();
        }
    }
}

/*** Output ***/
/*

    Web sites grouped by .com
        hsNameA.com
        hsNameB.com

    Web sites grouped by .net
        hsNameC.net
        hsNameD.net
        hsNameE.net

    Web sites grouped by .org
        hsNameF.org
        hsNameG.orf
    
    ..............

*/
