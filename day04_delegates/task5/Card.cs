using System;
namespace task5
{
	public class Card
	{
		public Suit Suit { get; private set; }
		public Number Number { get; private set; }

		public Card(Suit suit, Number number) => (Suit, Number) = (suit, number);

		public override string ToString()
		{
			return $"{Number} of {Suit}";
		}
	}
}

