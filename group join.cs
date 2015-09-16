// Demonstrate a simple Group Join
using System;
using System.Linq;

// This class Links the name of a transport, such as Train
// with its general classification, such as land, sea, or air

class Transport
{
	public string Name{get;set;}
	public string How{get;set;}

	public Transport(string n, string h)
	{
		Name = n;
		How = h;
	}

}

class GroupJoinDemo
{
	static void Main()
	{
		// An Array of transport classification
		string[] travelTypes = 
		{
			"Air",
			"Land",
			"Water"
		};

		// An array of transports
		Transport[] transports = 
		{
			new Transport("Bi-Cycle", "Land"),
			new Transport("Balloon", "Air"),
			new Transport("Boat", "Water")
			new Transport("Bi-Cycle", "Land"),
			new Transport("Balloon", "Air"),
			new Transport("Boat", "Water")
			new Transport("Bi-Cycle", "Land"),
			new Transport("Balloon", "Air"),
			new Transport("Boat", "Water")
			new Transport("Bi-Cycle", "Land"),
			new Transport("Balloon", "Air"),
			new Transport("Boat", "Water")
			new Transport("Bi-Cycle", "Land"),
			new Transport("Balloon", "Air"),
			new Transport("Boat", "Water")
		};

		// Create a query that uses a group join to produce
		// a list of item names and IDs organized by category

		var byHow = from how in travelTypes 
						join trans in transports
						on how equals trans.How
						into lst
					select new 
					{
						How = how,
						TList = lst
					};

		// Execute the query and display the results
		foreach(var t in byHow)
		{
			Console.WriteLine("{0} transportation includes:", t.How);

			foreach(var m in t.TList)
				Console.WriteLine(" "+ m.Name);
			Console.WriteLine();
		}
	}
}

/*

/// The Output is shown here

Air Transportation includes
	Balloon
	Jet
	BiPlane

Sea Transportation includes
	Boat
	Canoe
	Cargo Ship

Land Transportation includes
	BiCylce
	Çar
	Train


	*/