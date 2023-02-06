using System;
namespace task3
{
	public class Inspector : Mechanic
	{
		public int InspectionsThisWeek { get; set; }

		public Inspector(
			string name,
			string address,
			int gradYear,
			double hourlyWage) : base(name, address, gradYear, hourlyWage)
		{
		}

        public override double WeeklySalary()
        {
			return InspectionsThisWeek * 290;
        }
    }
}

