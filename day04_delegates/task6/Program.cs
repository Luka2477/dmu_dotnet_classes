namespace task6;
class Program
{
	static void Main(string[] args)
	{
		List<Person> people = new()
		{
			new Person(22, 80, "Lukas"),
			new Person(60, 105, "Per"),
			new Person(26, 91, "Lasse")
		};

		//people.Sort(new ByAgeSorting());
		//PrintList<Person>(people);

		//people.Sort(new ByWeightSorting());
		//PrintList<Person>(people);

		//people.Sort(new ByNameSorting());
		//PrintList<Person>(people);

		people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
		PrintList<Person>(people);

		people.Sort((p1, p2) => p1.Weight.CompareTo(p2.Weight));
		PrintList<Person>(people);

		people.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
		PrintList<Person>(people);
	}

	static void PrintList<T>(List<T> list)
	{
		foreach (T element in list)
		{
			Console.WriteLine(element);
		}
		Console.WriteLine();
	}
}

