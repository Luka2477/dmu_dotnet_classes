namespace task3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the amount of desired Fibo numbers: ");
        string? read = Console.ReadLine();
        
        if (read == null || read == "") return;

        bool didParse = int.TryParse(read, out int len);

        if (!didParse) return;

        Console.WriteLine("Itterative...");
        FibonacciItterative(len);
        int[] arr1 = FibonacciItterativeArray(len);
        Console.WriteLine($"[{string.Join(", ", arr1)}]");

        Console.WriteLine();

        Console.WriteLine("Recursive...");
        FibonacciRecursive(len);
        int[] arr2 = FibonacciRecursiveArray(len);
        Console.WriteLine($"[{string.Join(", ", arr2)}]");
    }

    static void FibonacciItterative(int len)
    {
        int i = 0, a = 0, b = 1;
        while (i < len)
        {
            Console.Write($"{b} ");
            i++;

            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine();
    }

    static int[] FibonacciItterativeArray(int len)
    {
        int[] arr = new int[len];
        int i = 0, a = 0, b = 1;
        while (i < len)
        {
            arr[i++] = b;

            int c = a + b;
            a = b;
            b = c;
        }

        return arr;
    }

    static void FibonacciRecursive(int len)
    {
        FibonacciRecursive(0, 1, 0, len);

        Console.WriteLine();
    }

    static void FibonacciRecursive(int a, int b, int i, int len)
    {
        if (i >= len) return;

        Console.Write($"{b} ");

        FibonacciRecursive(b, a + b, ++i, len);
    }

    static int[] FibonacciRecursiveArray(int len)
    {
        return FibonacciRecursiveArray(0, 1, 0, new int[len], len);
    }

    static int[] FibonacciRecursiveArray(int a, int b, int i, int[] arr, int len)
    {
        if (i >= len) return arr;

        arr[i++] = b;

        return FibonacciRecursiveArray(b, a + b, i, arr, len);
    }
}

