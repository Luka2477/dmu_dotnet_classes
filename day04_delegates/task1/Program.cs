namespace task1;
class Program
{
    static void Main(string[] args)
    {
        string longString = "I am a long string";
        Console.WriteLine(longString.Long(10));

        string shortString = "Oops";
        Console.WriteLine(shortString.Long(6));
    }
}

