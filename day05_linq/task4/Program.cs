using System.Runtime.ConstrainedExecution;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task3;
class Program
{
	static void Main(string[] args)
	{
		List<Person> people = new();

		try
		{
			people = Person.ReadCSVFile("/Users/lukasknudsen/Documents/dmu/dotnet/dmu_dotnet_classes/day05_linq/task4/assets/data1.csv");
		}
		catch (Exception ex)
		{
			Console.WriteLine("EXCEPTION: " + ex.Message);
			Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
		}

		// Brug FindIndex metoden på listen til at finde index på den første person med en score på præcis 3.
		int res1 = people.FindIndex(person => person.Score == 3);
		//Console.WriteLine(res1);

		// Brug FindIndex til at finde index på den første person under 10 år, som har en score på 3.
		int res2 = people.FindIndex(person => person.Age < 10 && person.Score == 3);
		//Console.WriteLine(res2);

		// Hvor mange personer er der under 10 år som har en score på 3? (Hint: Her skal du bruge FindAll...) 
		int res3 = people.FindAll(person => person.Age < 10 && person.Score == 3).Count;
		//Console.WriteLine(res3);

		// Brug FindIndex til at finde index på den første personer under 8 år, med en score på 3.Bemærk return value her – hvad betyder dette ?
		int res4 = people.FindIndex(person => person.Age < 8 && person.Score == 3);
		//Console.WriteLine(res4);
	}
}

