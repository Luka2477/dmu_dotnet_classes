using System.Runtime.ConstrainedExecution;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task6;
class Program
{
	static void Main(string[] args)
	{
		List<Person> people = new();

		try
		{
			people = Person.ReadCSVFile("/Users/lukasknudsen/Documents/dmu/dotnet/dmu_dotnet_classes/day05_linq/task6/assets/data1.csv");
		}
		catch (Exception ex)
		{
			Console.WriteLine("EXCEPTION: " + ex.Message);
			Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
		}

		people.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
		PrintList(people);
	}

	public static void PrintList<T>(List<T> list)
	{
		foreach (T el in list)
		{
			Console.WriteLine(el);
		}
		Console.WriteLine();
	}
}

