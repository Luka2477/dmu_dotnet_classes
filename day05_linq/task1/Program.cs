namespace task1;
class Program
{
	static void Main(string[] args)
	{
		List<int> ints = new List<int> { 10, 12, 2143, 345, 456, 56, 678, 4, 3 };

		ints.ForEach((val) =>
		{
			if (val % 2 == 0)
			{
				Console.WriteLine(val);
			}
		});

		int temp = 0;
		ints.ForEach((val) =>
		{
			if (val > 15)
			{
				temp = val;
			}
		});
		Console.WriteLine(temp);

		int index = 0;
		ints.ForEach((val) =>
		{
			if (val > 15)
			{
				index = ints.IndexOf(val);
			}
		});
		Console.WriteLine(index);
	}
}

