using System;
namespace task5
{
	public class Foreman : Mechanic
	{
		public int StartYear { get; set; }
		public double WeeklyBonus { get; set; }

		public Foreman(
			CPR cpr,
			string name,
			string address,
			int gradYear,
			double hourlyWage,
			int startYear,
			double weeklyBonus) : base(cpr, name, address, gradYear, hourlyWage)
			=> (StartYear, WeeklyBonus) = (startYear, weeklyBonus);

        public override double WeeklySalary()
        {
            return base.WeeklySalary() + WeeklyBonus;
        }
    }
}

