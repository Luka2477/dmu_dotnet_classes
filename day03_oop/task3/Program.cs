namespace task3;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new()
        {
            new Mechanic("Mads", "abc 124", 2012, 300),
            new Inspector("Lasse", "abc 125", 2015, 275),
            new Foreman("Morten", "abc 126", 2009, 350, 2017, 15000),
        };

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.WeeklySalary());
        }
    }
}

