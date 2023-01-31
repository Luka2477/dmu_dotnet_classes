namespace task7;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        MyList myList = new MyList();
        for (int i = 0; i < 10; i++)
        {
            myList.Add(random.Next(1, 101));
        }
        myList.PrintNumbers();
    }
}

