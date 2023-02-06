using System;
namespace task7
{
	public class Employee : IHasAddress
	{
        public Address Address { get; set; }

        public Employee(Address address) => Address = address;
    }
}

