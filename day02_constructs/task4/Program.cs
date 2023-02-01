namespace task4;
class Program
{
    static void Main(string[] args)
    {
        CalcAge(new DateTime(2000, 02, 19), out int age);
        Console.WriteLine($"You are {age} years old!");
    }

    static void CalcAge(DateTime birthday, out int age)
    {
        DateTime now = DateTime.Now;
        TimeSpan difference = now.Subtract(birthday);

        age = (int) difference.TotalDays / 365;
    }
}

