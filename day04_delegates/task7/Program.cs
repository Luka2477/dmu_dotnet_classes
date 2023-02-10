namespace task7;
class Program
{
	public static void Main(string[] args)
	{
		List<Person> people = Person.CreateListOfPeople();

		while (true)
		{
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Hvordan vil du have udskrevet navnene?");
			Console.WriteLine("1: Efternavn efterfulgt af fornavn");
			Console.WriteLine("2: Efternavn efterfulgt af fornavn, store bogstaver");
			Console.WriteLine("3: Efternavn efterfulgt af fornavn, små bogstaver");
			Console.WriteLine("4: Kun forbogstav af fornavn efterfulgt af efternavn");
			Console.WriteLine();
			Console.WriteLine("q: For at afslutte!");
			Console.Write("> ");
			string? input = Console.ReadLine();
			switch (input?.ToUpper())
			{
				case "1":
					PrintPeople(people, (fname, lname) => $"{lname} {fname}");
					break;
				case "2":
					PrintPeople(people, (fname, lname) => $"{lname.ToUpper()} {fname.ToUpper()}");
					break;
				case "3":
					PrintPeople(people, (fname, lname) => $"{lname.ToLower()} {fname.ToLower()}");
					break;
				case "4":
					PrintPeople(people, (fname, lname) => $"{lname.ToUpper()[0]} {fname}");
					break;
				case "Q": return;
				default:
					Console.WriteLine("Ukendt valg, prøv igen");
					break;
			}
		}
	}

	public static void PrintPeople(List<Person> people, FormatPersonName formatter)
	{
		foreach (Person person in people)
		{
			person.PrintPersonName(formatter);
		}
	}
}

