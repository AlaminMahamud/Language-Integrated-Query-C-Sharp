// Expression Tree

// A Simple Expression Tree
using System;
using System.Linq;
using System.Linq.Expressions;

class simpleExpTree
{
	static void Main()
	{
		// Represent a Lambda Expression As Data
		Expression<Func<int, int. bool>> IsFactorExp = (n,d) => (d!=0) ? (n%d)==0:false;

		// Compile the Expression Data into executable Code
		Func<int, int, bool> IsFactor = IsFactorExp.Compile();

		// Execute the Expression
		if(IsFactor(10,5))
			Console.WriteLine("5 is a factor of 10");
		if(!IsFactor(7,10))
			Console.WriteLine("7 is not a factor of 10");

		Console.WriteLine();
	}
}



/// The Output is shown here

// 5 is a factor of 10
// 7 is not a factor of 10

