namespace task10;
class Program
{
	static void Main(string[] args)
	{
		Random random = new Random();
		List<int> ints = new();

		for (int i = 0; i < 100; i++)
		{
			ints.Add(random.Next(1, 100));
		}

		// Find antallet af ulige tal I listen.
		IEnumerable<int> res1 = from n in ints
														where n % 2 != 0
														select n;
		//PrintEnumerable(res1);

		// Find antallet af unikke tal I listen (f.eks. skal 3,3,5 give 2 )
		int res2 = (from n in ints
								select n).Distinct().Count();
		//Console.WriteLine(res2);

		// Find de tre første ulige tal.
		IEnumerable<int> res3 = (from n in ints
														 where n % 2 != 0
														 orderby n
														 select n).Take(3);
		//PrintEnumerable(res3);

		// Find alle unikke ulige tal.
		IEnumerable<int> res4 = (from n in ints
														 where n % 2 != 0
														 orderby n
														 select n).Distinct();
		//PrintEnumerable(res4);
	}

	public static void PrintEnumerable<T>(IEnumerable<T> e)
	{
		foreach (T el in e)
		{
			Console.WriteLine(el);
		}
	}
}

