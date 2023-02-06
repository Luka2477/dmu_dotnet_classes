namespace task8;
class Program
{
    static void Main(string[] args)
    {
        Time time = new("00:00:00");
        Console.WriteLine(time);
        Console.WriteLine(time.SecondsSinceMidnight());

        time.Hour = 11;
        time.Min = 32;
        time.Sec = 16;
        Console.WriteLine(time);
        Console.WriteLine(time.SecondsSinceMidnight());

        time.Hour += 13;
        time.Sec += 45;
        Console.WriteLine(time);
        Console.WriteLine(time.SecondsSinceMidnight());

        time = new("12:30:11");
        Console.WriteLine(time);
        Console.WriteLine(time.SecondsSinceMidnight());
    }
}

