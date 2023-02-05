namespace task0
{
	public class Rectangle : Shape
	{
		public double Length;
		public double Width;

		public Rectangle(double length, double width) : base() => (Length, Width) = (length, width);

        public override string ToString()
        {
            return $"Rectangle : {base.ToString()}, Length={Length}, Width={Width}";
        }
    }
}

