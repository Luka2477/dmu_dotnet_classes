namespace task5.Models;

public class MusicCD : Product
{
    public string Artist;
    public ICollection<Track> Tracks = new List<Track>();

    public MusicCD() { }

    public MusicCD(string title, double price, string publisher, short published, string artist) : base(title, price,
        publisher, published)
    {
        Artist = artist ?? throw new ArgumentNullException(nameof(artist));
    }
}