namespace task0
{
	public class Shape
	{
		public double X;
		public double Y;

		public Shape() : this(1, 1)
		{

		}

		public Shape(double x, double y) => (X, Y) = (x, y);

        public override string ToString()
        {
			return $"X={X}, Y={Y}";
        }
    }
}

