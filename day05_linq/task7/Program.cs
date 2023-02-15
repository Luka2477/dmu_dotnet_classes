using System.Runtime.ConstrainedExecution;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task7;
class Program
{
	static void Main(string[] args)
	{
		List<Person> people = new();

		try
		{
			people = Person.ReadCSVFile("/Users/lukasknudsen/Documents/dmu/dotnet/dmu_dotnet_classes/day05_linq/task7/assets/data1.csv");
		}
		catch (Exception ex)
		{
			Console.WriteLine("EXCEPTION: " + ex.Message);
			Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
		}

		IEnumerable<Person> res1 = from person in people
															orderby person.Score ascending
															select person;
		//PrintEnumerable(res1);

		IEnumerable<Person> res2 = from person in people
															 orderby person.Score descending
															 select person;
		//PrintEnumerable(res2);

		IEnumerable<Person> res3 = from person in people
															 orderby person.Age ascending
															 select person;
		//PrintEnumerable(res3);

		IEnumerable<Person> res4 = from person in people
															 orderby person.Age descending
															 select person;
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

