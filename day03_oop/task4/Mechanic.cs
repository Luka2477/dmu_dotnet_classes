using System;
namespace task4
{
	public class Mechanic : Employee
	{
		public int GradYear { get; set; }
		public double HourlyWage { get; set; }

		public Mechanic(CPR cpr, string name, string address, int gradYear, double hourlyWage)
			: base(cpr, name, address) => (GradYear, HourlyWage) = (gradYear, hourlyWage);

		public override double WeeklySalary()
		{
			return HourlyWage * 37;
		}
	}
}

