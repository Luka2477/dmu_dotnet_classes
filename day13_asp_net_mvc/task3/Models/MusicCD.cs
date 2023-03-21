namespace task3.Models;

public class MusicCD : Product
{
    public string Artist;
    public ICollection<string> Tracks = new List<string>();
}