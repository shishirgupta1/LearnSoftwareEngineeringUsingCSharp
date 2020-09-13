<Query Kind="Program" />

//Implement a Linq Batch method.It should take an IEnumerable<T> and batchSize as an integer.It should return IEnumerable < IEnumerable < T >> that returns the original IEnumerable broken down in batch size.
//E.g., Imagine you have an IEnumerable<int> that has 1000 items.If I call, Batch method on it passing it 100, it should give me 10 IEnumerable<int> each having 100 elements.
//  Link to the exercise worksheet: https://cutt.ly/CSharpExercises

   void Main()
{
	var example = new List<int>();
	for(var i=0; i<1000; i++)
	{
		example.Add(i);
	}
	var batches = example.Batch(100);
	batches.Dump();
}

public static class Batches
{
	public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int batchSize)
	{
		var split = 0;
		return source.GroupBy(x => split++ / batchSize);
	}
}