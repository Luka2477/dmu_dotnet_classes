using System;
namespace task6
{
	public class Employee : IHasAddress
	{
        public string Address { get; set; }

        public Employee(string address) => Address = address;
    }
}

