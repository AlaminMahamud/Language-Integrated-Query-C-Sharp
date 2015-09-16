/*
	You can also use the query-related extension Methods within a query based on the C# Query Syntax

	Infact it is quite common to do so.

	For Example, this program uses Average() to obtain a sequence that contains only those values that are less than the average of the values in the array
*/


/// Use Average() with the query Syntax
using System;
using System.Linq;	

class ExtMethods2
{
	static void Main(string[] args)
	{
		int[] nums = {1,2,3,4,5,6,7,8,9};

		/// Creating the query 
		var ltAvg = from b in nums
					let x = nums.Average();
					where b<x;
					select b;

		// Output the Average
		Console.WriteLine("The Average is " + nums.Average());

		// Execute the Query and display the results
		foreach(var i in ltAvg)
			Console.Write(i + " ");
		Console.WriteLine();
	}
}


// The outout is Here
// The Average is 5.6
// 1 2 4 3
