namespace task4.Models;

public class MusicCD : Product
{
    public string Artist;
    public ICollection<string> Tracks = new List<string>();

    public MusicCD() { }

    public MusicCD(string title, double price, string publisher, short published, string artist) : base(title, price,
        publisher, published)
    {
        Artist = artist ?? throw new ArgumentNullException(nameof(artist));
    }
}