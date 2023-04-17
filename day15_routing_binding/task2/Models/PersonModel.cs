namespace task2.Models;

public class PersonModel
{
    public IName Name { get; set; }
    public int Age { get; set; }

    public PersonModel() { }

    public PersonModel(IName name, int age)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Age = age;
    }

    public class IName
    {
        public string First { get; set; }
        public string Last { get; set; }
    }
}