namespace task2;
class Program
{
	static void Main(string[] args)
	{
		List<int> ints = new List<int> { 12, 10, 2143, 345, 456, 56, 678, 4, 3 };

		IEnumerable<int> res = ints.Where(val => val % 2 == 0);
		foreach (int val in res)
		{
			Console.WriteLine(val);
		}
		Console.WriteLine();

		res = ints.Where(val => val > 9 && val < 100);
		foreach (int val in res)
		{
			Console.WriteLine(val);
		}
		Console.WriteLine();

		res = res.OrderBy(val => val);
		foreach (int val in res)
		{
			Console.WriteLine(val);
		}
		Console.WriteLine();
	}
}

