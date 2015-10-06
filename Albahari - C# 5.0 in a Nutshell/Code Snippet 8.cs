IEnumerable<char> query = "Not What You might except";
string vowels = "aeiou";

for(int i=0; i < vowels.Length; i++)
	query = query.Where(c=> c!=vowels[i]);

foreach (char c in query) 
	Console.Write(c);

