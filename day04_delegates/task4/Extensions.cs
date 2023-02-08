using System;
namespace task4
{
	public static class Extensions
	{
		public static int Power(this int n, int p)
		{
			if (p <= 0) return 0;

			int sum = n;
			for (int i = 1; i < p; i++)
			{
				sum *= n;
			}

			return sum;
		}
	}
}

