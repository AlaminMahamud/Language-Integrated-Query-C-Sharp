using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		string names={"Tom", "Dick", "Harry"};
		IEnumerable<string> filteredNames = names.Where(n=> n.Length >=4);
		foreach(string n in filteredNames)
			Console.WriteLine(n);
	}
}

/// Output 
//	Dick
//  Harry