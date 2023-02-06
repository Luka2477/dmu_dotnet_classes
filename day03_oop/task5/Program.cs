namespace task5;
class Program
{
    static void Main(string[] args)
    {
        Mechanic mech = new Mechanic(new CPR("190200", "5109"), "Mads", "abc 124", 2012, 300);

        EmployeeList<int> employees = new();
        employees.AddElement(0, mech);
        employees.AddElement(1, new Inspector(new CPR("010101", "1234"), "Lasse", "abc 125", 2015, 275));
        employees.AddElement(2, new Foreman(new CPR("020202", "9876"), "Morten", "abc 126", 2009, 350, 2017, 15000));
        employees.AddElement(3, mech);

        Console.WriteLine(employees.Size());
        Console.WriteLine(employees.GetElement(0) == employees.GetElement(3));
        Console.WriteLine(employees.GetHashCode());
    }
}

