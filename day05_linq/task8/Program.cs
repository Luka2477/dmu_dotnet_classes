namespace task8;
class Program
{
	static void Main(string[] args)
	{
		int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

		// Returner alle two-digit integers sorteret i ascending order.
		IEnumerable<int> res1 = from n in numbers
														where n > 9 && n < 100
														orderby n ascending
														select n;
		//PrintEnumerable(res1);

		// Returner alle two-digit integers sorteret i descending order.
		IEnumerable<int> res2 = from n in numbers
														where n > 9 && n < 100
														orderby n descending
														select n;
		//PrintEnumerable(res2);

		// Som i delopgave 1), men I stedet for integers, så skal der returneres strings dvs. f.eks. ”20”, ”31”, ”34”, etc.
		IEnumerable<string> res3 = from n in numbers
														where n > 9 && n < 100
														orderby n descending
														select n.ToString();
		//PrintEnumerable(res3);

		// Som i delopgave 2), men skal returnere string af typen “20 even”, “31 uneven”, etc... 
		IEnumerable<string> res4 = from n in numbers
															 where n > 9 && n < 100
															 orderby n descending
															 select n.ToString() + (n % 2 == 0 ? " even" : " uneven");
		PrintEnumerable(res4);
	}

	public static void PrintEnumerable<T>(IEnumerable<T> e)
	{
		foreach (T el in e)
		{
			Console.WriteLine(el);
		}
	}
}

