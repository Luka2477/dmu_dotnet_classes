using System;
namespace task5
{
	public class CardDeck
	{
		private List<Card> _deck = new();

		public void Add(Suit suit, Number number)
		{
			_deck.Add(new Card(suit, number));
		}

		public void Add(params Card[] cards)
		{
			foreach (Card card in cards)
			{
				_deck.Add(card);
			}
		}

		public CardDeck Filter(Util.FilterCardDeckDelegate filter)
		{
			CardDeck deck = new();

			foreach (Card card in _deck)
			{
				if (filter(card))
				{
					deck.Add(card);
				}
			}

			return deck;
		}

		public override string ToString()
		{
			return $"CardDeck : [\n{String.Join(", ", _deck)}\n]";
		}
	}
}

