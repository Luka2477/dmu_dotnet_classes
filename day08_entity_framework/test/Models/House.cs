using System;

namespace test.Models;

public class House
{
    public int ID { get; set; }
    public string Address { get; set; }

    public int OwnerID { get; set; }
    public virtual Person Owner { get; set; }

    public House()
    {
    }

    public House(string address)
    {
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public House(int id, string address)
    {
        ID = id;
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public House(string address, int ownerID)
    {
        Address = address ?? throw new ArgumentNullException(nameof(address));
        OwnerID = ownerID;
    }

    public House(int id, string address, int ownerID)
    {
        ID = id;
        Address = address ?? throw new ArgumentNullException(nameof(address));
        OwnerID = ownerID;
    }

    public override string ToString()
    {
        return Address;
    }
}