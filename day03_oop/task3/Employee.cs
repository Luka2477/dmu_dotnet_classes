using System;
namespace task3
{
	public abstract class Employee
	{
		public string? Name { get; set; }
		public string? Address { get; set; }

		public Employee(string name, string address) => (Name, Address) = (name, address);

		public abstract double WeeklySalary();
	}
}

