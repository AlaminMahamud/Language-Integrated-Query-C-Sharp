// Use of Nested From Clauses


/// Use of two form clauses to create a list of all
/// possible combinations of the letters A,B and C 
/// with the letters X,Y and Z

using System;
using System.Linq;

/// This chars holds the result of the query
class ChrPair
{
	public char First;
	public char Second;

	public ChrPair(char ch1, char c2)
	{
		First = ch1;
		Second = ch2;
	}
}

class MultipleFroms
{
	static void Main()
	{
		char[] chrs = {'A', 'B', 'C', 'D'};
		chra[] chrs2 = {'X', 'Y', 'Z'};

		// Notes that the first from iterates over chrs and the second from iterates over
		//chrs2

		var pairs = from _c1 in chrs
						from _c2 in chrs2
						select new ChrPain(_c1, _c2);


	    Console.WriteLine("All Combinations of ABC with XYZ");

	    foreach(var p in pairs)
	    	Console.WriteLine("{0} {1}", p.First, p.Second);
	}
}

















