using System;
namespace task7
{
    public class Company : IHasAddress
    {
        public Address Address { get; set; }

        public Company(Address address) => Address = address;
    }
}

