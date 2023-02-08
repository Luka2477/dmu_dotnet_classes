namespace task5;
class Program
{
	static void Main(string[] args)
	{
		CardDeck deck = new();

		foreach (int i in Enum.GetValues(typeof(Suit)))
		{
			foreach (int j in Enum.GetValues(typeof(Number)))
			{
				deck.Add((Suit)i, (Number)j);
			}
		}
		Console.WriteLine(deck);

		CardDeck clubs = deck.Filter(card => card.Suit == Suit.Clubs);
		Console.WriteLine(clubs);

		CardDeck pictures = deck.Filter(
			card => new List<Number> { Number.Jack, Number.Queen, Number.King }.Contains(card.Number)
		);
		Console.WriteLine(pictures);

		CardDeck nonPictures = deck.Filter(
			card => !new List<Number> { Number.Jack, Number.Queen, Number.King }.Contains(card.Number)
		);
		Console.WriteLine(nonPictures);
	}
}

