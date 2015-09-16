// Demonstrate Join
// use anonymous Type to improve the Join Demo program

using System;
using System.Linq;


// A class that links with item name with its number
class Item
{
	public string Name{get;set;}
	public int ItemNumber{get;set;}

	public Item(string n, int num)
	{
		Name = n;
		ItemNumber = num;
	}
}

// A class that links an item Number with its in-stock status
class InStockStatus
{
	public int ItemNumber{get;set;}
	public bool InStock{get;set;}

	public InStockStatus(int n, bool b)
	{
		ItemNumber = n;
		InStock = b;
	}
}

class AnnonTypeDemo
{
	static void Main()
	{
		// Some Item objects
		Item[] items = {
							new Items("Pillars", 1424),
							new Items("Hammer", 1324),
							new Items("Screw", 1213),
							new Items("Saw", 6411)
					   };	

		// Some InStockStatus objects
		InStockStatus[] statusList =
									{
										new InStockStatus("1424", true),
										new InStockStatus("7892", false),
										new InStockStatus("6411", true)	
									};

		// Create a query that joins Item with InStockStatus to 
		// produce a list of item names and avaialability.
		// Notice that Insted of a sequence of Temp objects is Produced
		// I am using an Anonymous Type
		var inStockList = from item in items 
						  join entry in statusList
						  	on item.ItemNumber equals entry.ItemNumber
						  select new {
						  			   Name=item.Name, 
						  			   entry.InStock
						  			 };
						  			 				  
	Console.WriteLine("Item\tAvailable\n");

	// Execute the query and display the results
	foreach(Temp t in InStockList)
		Console.WriteLine("{0}\t{1}", t.Name, t.InStock)

	}
}

/******* Output ***********

Items 	Available
Pliers 	True
Hammer 	False
Wrench 	True
Saw		True

*/













