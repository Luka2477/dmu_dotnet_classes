namespace task1.Models;

public class Product
{
    private string _manufacturer = string.Empty;
    
    public string Name { get; }
    public double Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string Manufacturer
    {
        get => _manufacturer;
        set => _manufacturer = value;
    }

    public Product(string name, double price)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Price = price;
    }

    public Product(string name, double price, string imageUrl, string manufacturer)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Price = price;
        ImageUrl = imageUrl ?? throw new ArgumentNullException(nameof(imageUrl));
        _manufacturer = manufacturer ?? throw new ArgumentNullException(nameof(manufacturer));
    }
}