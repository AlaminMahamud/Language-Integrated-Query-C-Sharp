/// Demonstrating Multiple Where Clause

using System;
using System.Linq;

class TwoWheres
{
	static void Main()
	{
		int[] nums = {1,-2,3,-3,0,-8,12,19,6,9,10};

		// Write a Query that obtains positive values less than 10
		var posNums = from n in nums
					  where n>0
					  where n<10
					  select n;

		Console.WriteLine("The Positive values less than 10: ");

		// Execute the query and display the results
		foreach(int i in posNums)
			Console.Write(i+ " ");
		Console.WriteLine();
	}
}