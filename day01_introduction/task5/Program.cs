using task5_lib;

namespace task5;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == null || input == "") break;

            Animal animal = new Animal(input);
            Console.WriteLine("Is animal a dog? " + animal.IsDog());
        }
    }
}

