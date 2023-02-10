using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
	public delegate string FormatPersonName(string firstname, string lastname);

	public class Person
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public static List<Person> CreateListOfPeople()
		{
			return new List<Person>()
						{
								new Person() { FirstName = "Stephen", LastName = "King" },
								new Person() { FirstName = "George", LastName = "Martin" },
								new Person() { FirstName = "Ernest", LastName = "Hemingway" },
								new Person() { FirstName = "William", LastName = "Shakespeare" }
						};
		}

		public void PrintPersonName(FormatPersonName formatter)
		{
			Console.WriteLine(formatter(FirstName, LastName));
		}
	}
}
