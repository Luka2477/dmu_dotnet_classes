namespace task2
{
	public class PowerPlant
	{
		private Warning? _warning;
		private readonly Random _random = new();

		public void SetWarning(Warning wa)
		{
			_warning = wa;
		}

		public void AddWarning(Warning wa)
		{
			_warning += wa;
		}

		public void HeatUp()
		{
			if (_warning == null) return;

			int temperature = _random.Next(0, 101);
			Console.WriteLine($"Temperature is {temperature}");

			if (temperature > 50)
			{
				_warning();
			}
		}
	}
}

