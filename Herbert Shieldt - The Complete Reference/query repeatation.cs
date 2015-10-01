// A Query can run more than once

// A Simple Query 

using System;
using System.Linq;
using System.Collections.Generic;

class SimpQuery
{
	static void Main(string[] args)
	{
		int[] nums = {1,2,3,4,5,6,7,8,9,10};

		// Create a Query that obtains only positive number
		var myQr = from n in nums
				   where n>0
				   select n;

		Console.Write("The positive value in nums");

		// Execute the query and display the results
		foreach(int i in myQr)
			Console.Write(i+" ");
		Console.WriteLine();

		// Change Nums
		Console.WriteLine("\n Setting nums[1] to 99");
		nums[1] = 99;

		Console.Write("The positive value in nums after change : ");

		// Execute the query for second time
		foreach(int i in myQr)
			Console.Write(i+ " ");

		Console.WriteLine();
	}

}	


////// The following output is produced:

//The positive values in nums : 1 2 3 4 5 6 7 8 9 10

//Setting nums[1] to 99
//The positive values in nums after change: 1 99 3 5


