namespace task6.Models;

public class Track
{
    public string Title;
    public string Composer;
    public string Length;

    public Track(string title, string composer, string length)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Composer = composer ?? throw new ArgumentNullException(nameof(composer));
        Length = length ?? throw new ArgumentNullException(nameof(length));
    }
}