// Data Types of Query Relation

var posNums = from int n in nums
		// ...

/// this is converted into the following compiled code

IEnumerable<int> posNums = from n in nums
						   where n > 0
						   select n;

						   