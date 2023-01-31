using System;
namespace task5_lib
{
	public class Animal : IAnimal
	{
		private string _species;

		public Animal(string species)
		{
			_species = species;
		}

		public string Species
		{
			get { return _species; }
			set { _species = value; }
		}

        public bool IsDog()
        {
			return _species.ToLower() == "dog";
        }
    }
}

