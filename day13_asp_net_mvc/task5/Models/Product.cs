namespace task5.Models;

public abstract class Product
{
    public string Title;
    public double Price;
    public string ImageUrl;
    public string Publisher;
    public short Published;

    protected Product() { }

    protected Product(string title, double price, string publisher, short published)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Price = price;
        Publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        Published = published;
    }
}