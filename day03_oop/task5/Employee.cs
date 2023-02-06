using System;
namespace task5
{
    public abstract class Employee
    {
        public CPR CPR { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public Employee(CPR cpr, string name, string address)
            => (CPR, Name, Address) = (cpr, name, address);

        public abstract double WeeklySalary();

        public override string ToString()
        {
            return $"Employee : CPR={CPR}, Name={Name,-10}, Address={Address,-15}, WeeklySalary={WeeklySalary(),-8}";
        }
    }
}

