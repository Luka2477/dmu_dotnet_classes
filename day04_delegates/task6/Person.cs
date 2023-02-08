using System;
namespace task6
{
	public class Person
	{
		public int Age { get; set; }
		public double Weight { get; set; }
		public string Name { get; set; }

		public Person(int age, double weight, string name)
		{
			Age = age;
			Weight = weight;
			Name = name ?? throw new ArgumentNullException(nameof(name));
		}

		public override string ToString()
		{
			return $"I am {Name}, I weigh {Weight}kg and am {Age} years old...";
		}
	}

	public class ByAgeSorting : IComparer<Person>
	{
		public int Compare(Person? x, Person? y)
		{
			return x.Age.CompareTo(y.Age);
		}
	}

	public class ByWeightSorting : IComparer<Person>
	{
		public int Compare(Person? x, Person? y)
		{
			return x.Weight.CompareTo(y.Weight);
		}
	}

	public class ByNameSorting : IComparer<Person>
	{
		public int Compare(Person? x, Person? y)
		{
			return x.Name.CompareTo(y.Name);
		}
	}
}

