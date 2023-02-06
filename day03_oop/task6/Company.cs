using System;
namespace task6
{
    public class Company : IHasAddress
    {
        public string Address { get; set; }

        public Company(string address) => Address = address;
    }
}

