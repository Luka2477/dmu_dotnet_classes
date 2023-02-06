namespace task4;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new()
        {
            new Mechanic(new CPR("190200", "5109"), "Mads", "abc 124", 2012, 300),
            new Inspector(new CPR("010101", "1234"), "Lasse", "abc 125", 2015, 275),
            new Foreman(new CPR("020202", "9876"), "Morten", "abc 126", 2009, 350, 2017, 15000),
        };

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}

