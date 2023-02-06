namespace task1;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new()
        {
            new Employee(),
            new Mechanic(),
            new Inspector(),
            new Foreman(),
        };

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}

