using System;
namespace task7
{
	public class Address
	{
		public string Street { get; set; }
		public int Number { get; set; }
		public string Apartment { get; set; }

		public Address(string street, int number, string apartment = "")
			=> (Street, Number, Apartment) = (street, number, apartment);
	}
}

