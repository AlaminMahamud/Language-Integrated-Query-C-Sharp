// Use several of the extension methods defined by Enumerable

using System;
using System.Linq;

class ExtMethods
{
	static void Main(string[] args)
	{
		int[] nums = {3,1,2,4,5};

		Console.WriteLine("The Minimum value is " + nums.Min());

		Console.WriteLine("The Maximum value is " + nums.Max());

		Console.WriteLine("The First value is " + nums.First());

		Console.WriteLine("The Last value is " + nums.Last());

		if(nums.All(n=> n>0))
			Console.WriteLine("All values are greater than zero");
		if(nums.Any(n=>n>0)) 
			Console.WriteLine("At least one value here is greater than zero");
		if(num.Contains(3)) 
			Console.WriteLine("The Array Contains 3");	

	}
}


	// The Output is shown here
