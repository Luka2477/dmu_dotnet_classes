namespace task8
{
	public struct Time
	{
		private const int _maxSeconds = 86_400;
		private int _secondsSinceMidnight;

		public int Hour
		{
			get
			{
				return _secondsSinceMidnight / 3_600;
			}
			set
			{
				int temp = _secondsSinceMidnight % 3_600;
				_secondsSinceMidnight = (temp + value * 3_600) % _maxSeconds;
			}
		}

		public int Min
		{
			get
			{
				return (_secondsSinceMidnight - Hour * 3_600) / 60;
			}
			set
			{
				int temp = _secondsSinceMidnight % 60;
				_secondsSinceMidnight = (temp + value * 60 + Hour * 3_600) % _maxSeconds;

			}
		}

		public int Sec
		{
			get
			{
				return _secondsSinceMidnight - Hour * 3_600 - Min * 60;
			}
			set
			{
				_secondsSinceMidnight = (value + Min * 60 + Hour * 3_600) % _maxSeconds;
			}
		}

		public Time(string time)
		{
			string[] split = time.Split(":");
			Hour = Int32.Parse(split[0]);
			Min = Int32.Parse(split[1]);
			Sec = Int32.Parse(split[2]);
		}

		public int SecondsSinceMidnight() => _secondsSinceMidnight;

		public override string ToString()
		{
			return $"{Hour,2:D2}:{Min,2:D2}:{Sec,2:D2}";
		}
	}
}

