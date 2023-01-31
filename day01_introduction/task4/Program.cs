namespace task4;
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("martin");
        Console.WriteLine(person);
        person.Name = "Benny";
        Console.WriteLine(person);
    }
}

