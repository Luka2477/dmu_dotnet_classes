namespace task0
{
	public class Circle : Shape
	{
		public double Radius;

		public Circle(double radius) : base() => Radius = radius;

        public override string ToString()
        {
            return $"Circle : {base.ToString()}, Radius={Radius}";
        }
    }
}

