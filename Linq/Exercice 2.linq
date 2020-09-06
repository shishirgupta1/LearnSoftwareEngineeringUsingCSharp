<Query Kind="Program" />

void Main()
{
	var greetings = new Greeting();

	
	foreach (var item in greetings)
	{
		item.Dump();
	}
}

public class Greeting : IEnumerable<string>
{
	public IEnumerator<string> GetEnumerator()
	{
		return new GreetingEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new NotImplementedException();
	}
}


public class GreetingEnumerator : IEnumerator<string>
{
	private string _current = null;

	public string Current => _current;

	object IEnumerator.Current => throw new NotImplementedException();

	public void Dispose()
	{
		throw new NotImplementedException();
	}

	public bool MoveNext()
	{
		if(_current == null)
		{
			_current = "Hi";
			return true;
		}
		if (_current == "Hi")
		{
			_current = "Hello";
			return true;
		}
		if (_current == "Hello")
		{
			return false;
		}
		throw new InvalidOperationException("Invalid");
	}

	public void Reset()
	{
		throw new NotImplementedException();
	}
}
