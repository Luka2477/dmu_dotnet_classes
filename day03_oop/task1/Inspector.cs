using System;
namespace task1
{
	public class Inspector : Mechanic
	{
		public int InspectionsThisWeek { get; set; }
		public new double Salary { get => InspectionsThisWeek * 290; }

    }
}

