using System;
namespace task3
{
	public class Employee
	{
		public string? Name { get; set; }
		public string? Address { get; set; }

		public Employee(string name, string address) => (Name, Address) = (name, address);

		public virtual double WeeklySalary() => 0;
	}
}

