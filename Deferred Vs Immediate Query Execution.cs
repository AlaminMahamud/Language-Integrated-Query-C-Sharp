// Defered vs Immediate Query Execution

// use Immidiate query Execution

using System;
using System.Linq;

class ImmediateExec
{
	static void Main()
	{
		int[] nums = {1,2,3,4,5,6,7};

		// Create  a query that obtains the number of positive values in the nums
		int len = from n in nums
				  where n>0
				  select n.Count();

		Console.WriteLine("The number of positive values in nums: "+len);
	}
}

// The Output is
// The Number of Positive values in nums: 3
