<Query Kind="Program" />

void Main()
{
	var greeting1 = new Greeting();
	greeting1.Message = "Hi";
	var greeting2 = new Greeting();
	greeting2.Message = "Hello";
	var listOfGreetings = new Greeting();
	listOfGreetings.Add(greeting1);
	listOfGreetings.Add(greeting2);
	
	foreach (Greeting item in listOfGreetings)
	{
		item.Message.Dump();
	}
}

public class Greeting : IEnumerable
{
	Greeting[] Items = new Greeting[100];  
	int index = 0;  
	public string Message {get; set;}
	
	public void Add(Greeting item)
	{
		Items[index] = item;
		index++;
	}
	
	public IEnumerator GetEnumerator()
	{
		foreach (object item in Items)
		{
			if (item == null)
			{
				break;
			}
			yield return item;
		}
	}
}
// Define other methods and classes here
