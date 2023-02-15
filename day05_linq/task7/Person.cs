using System;
namespace task4
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public int Weight { get; set; }
		public int Score { get; set; }
		public bool Accepted { get; set; }

		public Person(string data)
		{
			var split = data.Split(';');

			Name = split[0];
			Age = int.Parse(split[1]);
			Weight = int.Parse(split[2]);
			Score = int.Parse(split[3]);
			Accepted = false;
		}

		public override string? ToString()
		{
			return $"{Name} is {Age}, weighs {Weight}kg, has a score of {Score} and is {(Accepted ? string.Empty : "not ")}accepted";
		}

		public static List<Person> ReadCSVFile(string filename)
		{
			List<Person> list = new();
			using (var file = new StreamReader(filename))
			{
				string line = string.Empty;
				while ((line = file.ReadLine()) != null)
				{
					var p = new Person(line);
					list.Add(p);
				}
			}
			return list;
		}
	}
}

