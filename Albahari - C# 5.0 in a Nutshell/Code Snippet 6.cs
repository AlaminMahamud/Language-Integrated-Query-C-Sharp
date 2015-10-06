var numbers = new List<int>(){1,2,3};

IEnumerable<int> query = numbers.Select(n=>n*10); 

foreach(int n in query)
	Console.Write(n+"|"); // nothing

numbers.Clear();
foreach(int n in query)
	Console.WriteLine();
