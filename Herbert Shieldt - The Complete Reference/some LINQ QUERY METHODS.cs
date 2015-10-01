/// Another LINQ Method

var inStockList = from item in items
				  join entry in statusList
				  	on item.ItemNumber equals entry.ItemNumber
				  select new Temp(item.Name, entry.InStock);

/// use Join() to Produce a list of items and status

var inStockList = items.Join(
								statusList,
								k1 => k1.ItemNumber,
								k2 => k2.ItemNumber,
								(k1,k2) => new Temp(k1.Name, k2.InStock);
							);

var inStockList = items.Join(statusList,
							k1=>k1.ItemNumber,
							k2=>k2.ItemNumber,
							(k1,k2) => new {k1.Name, k2.Name}
							);

