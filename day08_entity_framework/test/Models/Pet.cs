using System;

namespace test.Models;

public class Pet
{
    public int ID { get; set; }
    public string Name { get; set; }
    
    public int OwnerID { get; set; }
    public virtual Person Owner { get; set; }

    public Pet()
    {
    }

    public Pet(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public Pet(int id, string name)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public Pet(string name, int ownerID)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        OwnerID = ownerID;
    }

    public Pet(int id, string name, int ownerID)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        OwnerID = ownerID;
    }

    public override string ToString()
    {
        return Name;
    }
}