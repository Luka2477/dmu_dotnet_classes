using System;
namespace task4
{
	public class Inspector : Mechanic
	{
		public int InspectionsThisWeek { get; set; }

		public Inspector(
			CPR cpr,
			string name,
			string address,
			int gradYear,
			double hourlyWage) : base(cpr, name, address, gradYear, hourlyWage)
		{
		}

        public override double WeeklySalary()
        {
			return InspectionsThisWeek * 290;
        }
    }
}

