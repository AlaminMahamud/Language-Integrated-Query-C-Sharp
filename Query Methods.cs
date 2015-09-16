/// Create Queries by using Query Methods
/// this is reworked version of rtht first program in the chapter

using System;
using System.Linq;

class SimpQuery
{
	static void Main(string[] args)
	{
		int[] nums = {1,-2,3,4,5,6,-7};

		/// Use Where() and Select() to create a simple Query.
		var posNums = nums.Where(n=>n>0).Select(r=> r);

		Console.Write("The Positive values in nums: ");

		// Execute the Query and display the results
		foreach(int i in posNums)
			Console.Write(i+ " ");
		Console.WriteLine();
	}
}


/*
	The Positive value in Nums 1,3,5
*/
