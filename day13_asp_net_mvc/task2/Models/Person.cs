namespace task2.Models;

public class Person
{
    private DateTime _birthday;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Zip { get; set; }
    public string City { get; set; }

    public DateTime Birthday
    {
        get => _birthday;
        init
        {
            DateTime temp = _birthday;
            _birthday = value;

            if (Age is > 0 and < 120) return;

            _birthday = temp;
            throw new ArgumentException("Age must be between 0 and 120 years");
        }
    }

    public int Age => (int)((DateTime.Now - Birthday).TotalDays / 365);
    public List<string> PhoneNumbers { get; set; } = new();

    public Person(string firstName, string lastName, string address, string zip, string city)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Address = address ?? throw new ArgumentNullException(nameof(address));
        Zip = zip ?? throw new ArgumentNullException(nameof(zip));
        City = city ?? throw new ArgumentNullException(nameof(city));
    }

    public void AddPhoneNumber(string pn)
    {
        PhoneNumbers.Add(pn);
    }
}