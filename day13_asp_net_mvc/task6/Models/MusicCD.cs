namespace task6.Models;

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

    public TimeSpan GetPlayingTime()
    {
        TimeSpan playingTime = new();
        foreach (Track t in Tracks)
        {
            playingTime += TimeSpan.Parse(t.Length);
        }

        return playingTime;
    }
}