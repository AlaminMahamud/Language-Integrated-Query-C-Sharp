// Create a Simple Query
using System;
using System.LINQ;
using System.Collections.Generic;

class SimpleQuery
{
	static void Main()
	{
		int[] nums = {1,-2,3,0,-5,6};

		/// Write a Query that obtains a positive numbers;
		var posNums = from n in nums
				      where n > 0
				      select n;

		Console.WriteLine("The +ve value in nums : ");

		// Execute the query and display the resuts
		foreach(int i in posNums)
			Console.Write(i+ " ");
		Console.WriteLine();

		// Change Nums
		Console.WriteLine("\nSetting nums[1] to 99");
		nums[1] = 99;

		// Execute the query a second time
		foreach(int i in posNums) 
			Console.Write( i +" ");
		Console.WriteLine();
 	}
}