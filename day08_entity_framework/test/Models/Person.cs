using System;
using System.Collections.ObjectModel;

namespace test.Models;

public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    
    public virtual House House { get; set; }
    public virtual ObservableCollection<Pet> Pets { get; }

    public Person()
    {
    }

    public Person(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public Person(int id, string name)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public override string ToString()
    {
        return Name;
    }
}