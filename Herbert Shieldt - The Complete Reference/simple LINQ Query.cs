// Demonstrating a Simple Query
using System;
using System.Linq;

class SimpQuery
{
	static void Main(string[] args)
	{
		int[] nums = {1,2,3,4};

		// Create A Query That obtains only positive numbers
		var posNums = from n in nums
					  where n>0
					  select n;
		
		Console.WriteLine("Printing the Positive Number");

		// Execute the query and display the results
		foreach(int i in posNums)
			Console.WriteLine(i+ " ");

		Console.WriteLine();
	}
}


// The Program Produces the following Output:
// The positive values in nums: 1 3 5

