// Return a Portion of the Range Variable

using System;
using System.Linq;

class EmailAddress
{
	public string Name { get; set; }
	public string Address { get; set; }

	public EmailAddress(string n, string a)
	{
		Name = n;
		Address = a;
	}
}

class SelectDemo2
{
	static void Main(string[] args)
	{
		EmailAddress[] address = 
								{
									new EmailAddress
									("Herb", "herb@gmail.com"),

									new EmailAddress
									("Bray", "bray@hotmail.com"),

									new EmailAddress
									("Ryan", "ryan@gmail.com")

								};
		// Create A Query that selects an Email Address
		var eAddrs = from s in address
					 select s.Address;

		Console.WriteLine("The Email Addresses are");

		// Execute the query and display the results
		foreach (string s in eAddrs)
		{
			Console.WriteLine(" " + s);
		}

	}
}
