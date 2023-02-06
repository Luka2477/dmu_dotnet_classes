namespace task6;
class Program
{
    static void Main(string[] args)
    {
        EmployeeList<int> employees = new();
        employees.AddElement(0, new Company("abc 123"));
        employees.AddElement(1, new Employee("abc 124"));

        Console.WriteLine(employees);
    }
}

