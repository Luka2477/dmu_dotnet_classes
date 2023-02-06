namespace task0
{
	public abstract class Shape
	{
		public double X;
		public double Y;

		public Shape() : this(1, 1)
		{
		}

		public Shape(double x, double y) => (X, Y) = (x, y);

		public abstract double Area();

		public override string ToString()
        {
			return $"Area={Area()}, X={X}, Y={Y}";
        }
    }
}

