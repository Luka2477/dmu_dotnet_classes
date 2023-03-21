namespace task4.Models;

public class Book : Product
{
    public string Author;
    public string ISBN;

    public Book() { }

    public Book(string title, double price, string publisher, short published, string author) : base(title, price,
        publisher, published)
    {
        Author = author ?? throw new ArgumentNullException(nameof(author));
    }
}