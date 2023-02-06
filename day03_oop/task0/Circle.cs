namespace task0
{
	public class Circle : Shape
	{
		public double Radius;

		public Circle(double radius) : base() => Radius = radius;

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            return $"Circle : Radius={Radius}, {base.ToString()}";
        }
    }
}

