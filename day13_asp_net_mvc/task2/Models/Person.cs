namespace task2.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Zip { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; } = "NULL";

    public Person(string firstName, string lastName, string address, string zip, string city)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Address = address ?? throw new ArgumentNullException(nameof(address));
        Zip = zip ?? throw new ArgumentNullException(nameof(zip));
        City = city ?? throw new ArgumentNullException(nameof(city));
    }
}