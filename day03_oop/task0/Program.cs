namespace task0;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new()
        {
            new Circle(2.5),
            new Circle(5),
            new Rectangle(15, 25)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}

