using System;
namespace task3
{
	public static class Extensions
	{
		public static int Factorial(this int n)
		{
			return Factorial(n - 1, n);
		}

		public static int Factorial(int n, int sum)
		{
			if (n <= 0) return sum;

			return Factorial(n - 1, sum * n);
		}
	}
}

