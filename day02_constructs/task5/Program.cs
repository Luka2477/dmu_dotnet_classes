namespace task5;
class Program
{
    static void Main(string[] args)
    {
        MyNormalMethod(-15);
    }

    static private void MyMethodWithError(int num)
    {
        switch (num)
        {
            case < 0:
                throw new ArgumentOutOfRangeException("num cannot be < 0");

            case > 50:
                throw new ArgumentOutOfRangeException("num cannot be > 50");

            default:
                Console.WriteLine($"num is {num} which is valid!");
                break;
        }
    }

    static public void MyNormalMethod(int num = 0)
    {
        try
        {
            MyMethodWithError(num);
        }
        catch (ArgumentOutOfRangeException error)
        {
            Console.WriteLine(error.Message);
        }
        finally
        {
            Console.WriteLine("We are in the finally clause...");
        }
    }
}

