using System;
namespace task3
{
	public class Mechanic : Employee
	{
		public int GradYear { get; set; }
		public double HourlyWage { get; set; }

		public Mechanic(string name, string address, int gradYear, double hourlyWage)
			: base(name, address) => (GradYear, HourlyWage) = (gradYear, hourlyWage);

		public override double WeeklySalary()
		{
			return HourlyWage * 37;
		}
	}
}

