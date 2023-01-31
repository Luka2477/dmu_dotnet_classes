using System;
namespace task4
{
	public class Person
	{
		private string _name;

		public Person(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public override string ToString()
        {
			return _name;
        }
    }
}

