namespace task2;
class Program
{
    static void Main(string[] args)
    {
        PowerPlant pp = new();
        pp.SetWarning(WarningToConsole);

        while (true)
        {
            pp.HeatUp();

            Thread.Sleep(1000);
        }
    }

    static void WarningToConsole()
    {
        Console.WriteLine("⚠️ Warning ⚠️");
    }
}

