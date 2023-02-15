using System;
namespace task9
{
	public static class Extensions
	{
		public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
		{
			lst.FindAll(pred).ForEach(person => person.Accepted = true);
		}

		public static void Reset(this List<Person> list)
		{
			list.ForEach(person => person.Accepted = false);
		}
	}
}

