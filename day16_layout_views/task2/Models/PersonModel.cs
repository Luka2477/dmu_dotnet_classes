namespace task2.Models;

public class PersonModel
{
    public Name FullName { get; set; }
    public int Age { get; set; }

    public PersonModel(Name fullName, int age)
    {
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        Age = age;
    }

    public class Name
    {
        public string First { get; set; }
        public string Last { get; set; }

        public Name(string first, string last)
        {
            First = first ?? throw new ArgumentNullException(nameof(first));
            Last = last ?? throw new ArgumentNullException(nameof(last));
        }
    }
}