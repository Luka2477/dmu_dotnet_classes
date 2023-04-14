using System.Runtime.InteropServices;

namespace task1.Models;

public class PersonModel
{
    public IName Name;
    public int Age;

    public PersonModel(IName name, int age)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Age = age;
    }

    public class IName
    {
        public string First;
        public string Last;
    }
}