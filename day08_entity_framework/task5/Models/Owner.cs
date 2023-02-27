using System;

namespace task5.Models;

public class Owner
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Cpr { get; set; }

    public int CarID { get; set; }
    public virtual Car Car { get; set; }

    public Owner()
    {
    }

    public Owner(string name, int cpr)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Cpr = cpr;
    }

    public override string ToString()
    {
        return $"Owner: {{ID={ID}, Name={Name}, Cpr={Cpr}}}";
    }
}