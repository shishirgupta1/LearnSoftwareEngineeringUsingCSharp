<Query Kind="Program" />

void Main()
{
	var listOfItems = new List<int>();
	listOfItems.Add(1);
	listOfItems.Add(2);
	listOfItems.Add(3);
	listOfItems.Add(4);
	listOfItems.Add(5);
	listOfItems.Add(6);
	listOfItems.Add(7);
	
	var enumerator = listOfItems.GetEnumerator();
	while(enumerator.MoveNext())
	{
		var item = enumerator.Current;
		Console.WriteLine(item);
	}
}

// Define other methods and classes here
