namespace task3;
class Program
{
	static void Main(string[] args)
	{
		List<Person> people = new();

		try
		{
			people = Person.ReadCSVFile("/Users/lukasknudsen/Documents/dmu/dotnet/dmu_dotnet_classes/day05_linq/task3/assets/data1.csv");
		}
		catch (Exception ex)
		{
			Console.WriteLine("EXCEPTION: " + ex.Message);
			Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
		}

		List<Person> scoreOver2 = people.FindAll(person => person.Score > 2);
		//PrintList(scoreOver2);

		List<Person> evenScore = people.FindAll(person => person.Score % 2 == 0);
		//PrintList(evenScore);

		List<Person> evenScoreAndWeightOver60 = people.FindAll(person => person.Score % 2 == 0 && person.Weight > 60);
		//PrintList(evenScoreAndWeightOver60);

		List<Person> weightMultipleOf3 = people.FindAll(person => person.Weight % 3 == 0);
		//PrintList(weightMultipleOf3);
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

