var numbers = new List<int>(){1,2};
List<int> timesTen = numbers
					 .Select(n=>n*10)
					 .ToList(); // Executes Immediately into a List<int>
numbers.Clear();
Console.WriteLine(timesTenCount); // still 2
