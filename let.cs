/// Use let to create a variable in query
/// in a query to retain a value temporarily

//let name = expression

// use a let cause and a nested from Claus

using System;
using System.Linq;

class LetDemo
{
	static void Main(string[] args)
	{
		// Create a Query that obtains the characters in the
		// strings, returned in sorted order.
		// Notice the use of a nested from clause

		string[] strs = {"Alpha", "Beta", "Gamma"};

		var chars = from str in strs
					let chArray = str.ToCharArray()
						from ch in chArray
						orderby ch
						select ch;

		Console.WriteLine("The Individual characters in sorted order");

		// Execute the query and display the resutls
		foreach(char c in chars)
			Console.Write(c+" ");
		Console.WriteLine(); 
	}
}


/********** The Output **********

	The individual characters in sorted order
	a a a a a a b e g h l m m p t
	


*/


