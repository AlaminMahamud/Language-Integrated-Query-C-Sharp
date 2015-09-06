// Demonstrate OrderBy
using System;
using System.Linq;

class OrderByDemo
{
	static void Main()
	{
		int[] nums = {1,2,4,5,6,7,2,1};

		// Create a Query that obtains the values in sorted order
		var posNums = from n in nums
					  orderby n
					  select n;

		// Create antoher Query that obtains the values in decending sorted order
		var posNums2 = from n in nums
					   orderby n descending
					   select n;					  


		// Execute the Query and display the results
		foreach(int i in posNums) 
			Console.Write(i+" ");
		Console.WriteLine();		
		
	}
}
