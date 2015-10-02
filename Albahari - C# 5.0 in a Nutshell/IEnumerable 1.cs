string[] names = {"Tom", "Dick", "Harry"};
IEnumerable<string> fnames = System.Linq.Enumerable.Where(names, n=>n.Length>=4);
foreach(string s in fnames)
	Console.WriteLine(s);


/// 
IEnumerable<String> filteredNames = names.Where(n=>n.Length>=4);
