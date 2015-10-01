/// An Extension Method is a static methods that must be contained within a static, non-generic class. The type of its first parameter derermines the type of objects on which the extension method can be called

// Furthermore. the first parameter must be modified by this.



// Create and Use Some Extension method
using System;
using System.Globalization;
static class MyExtMethods
{
	// Reciprocal of a double
	public static double Reciprocal(this double v)
		return 1.0/v;
	
	// Reverse the case of letters within a string and 
	// return the result
	public static string RevCase(this string str)
	{
		string temp = "";
		foreach (char ch in str)
		{
			if(Char.IsLower(ch)) 
				temp+= Char.ToUpper(ch,CultureInfo.CurrentCulture);
			else
				temp += Char.ToLower(ch,CultureInfo.CurrentCulture); 
		}
		return temp;
	}

	// Return the absolute value of n/d
	public static double AbsDivideBy(this double n, double d)
		return Math.Abs(n/d);
}

class ExtDemo
{
	static void Main()
	{
		double val = 8.0;
		string str = "Alpha Beta Gamma";

		// Call the Reciprocal() extensions Method.
		Console.WriteLine("Reciprocal Of {0} and {1}", val , val.Reciprocal());

		// Call the RevCase() Extension Method
		Console.WriteLine(str + " after reversing case is " + str.RevCase());

		// Use AbsDivideBy();
		Console.WriteLine("Result of val.AbsDivideBy(-2) : "+ val.AbsDivideBy(-2));

	}	
}


// I can call any Extension Method like the following

	// 8.0.Reciprocal()
	// 8.0.AbsDivideBy(-1)
	