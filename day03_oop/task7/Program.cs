namespace task7;
class Program
{
    static void Main(string[] args)
    {
        EmployeeList<int> employees = new();
        employees.AddElement(0, new Company(new Address("abc", 123, "2. th")));
        employees.AddElement(1, new Employee(new Address("abc", 124)));

        Console.WriteLine(employees);
    }
}

