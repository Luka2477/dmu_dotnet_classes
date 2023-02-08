namespace task2;
class Program
{
	static void Main(string[] args)
	{
		PowerPlant pp = new();
		//pp.SetWarning(WarningToConsole);
		pp.AddWarning(() => WarningToConsole("!!! Warning !!!"));
		pp.AddWarning(() => WarningToConsole("The powerplant is too hot!!!"));

		while (true)
		{
			pp.HeatUp();

			Thread.Sleep(1000);
		}
	}

	static void WarningToConsole(string msg)
	{
		Console.WriteLine(msg);
	}
}

