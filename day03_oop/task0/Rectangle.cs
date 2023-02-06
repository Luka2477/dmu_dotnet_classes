namespace task0
{
	public class Rectangle : Shape
	{
		public double Length;
		public double Width;

		public Rectangle(double length, double width) : base() => (Length, Width) = (length, width);

        public override double Area()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return $"Rectangle : Length={Length}, Width={Width}, {base.ToString()}";
        }
    }
}

