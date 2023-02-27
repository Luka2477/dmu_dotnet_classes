using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace task3.Models;

public class Car
{
    public int ID { get; set; }
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public int Wheels { get; set; }
    public int Year { get; set; }

    public virtual ObservableCollection<Owner> Owners { get; }

    public Car()
    {
    }
    
    public Car(string make, string model, int wheels, int year)
    {
        Make = make ?? throw new ArgumentNullException(nameof(make));
        Model = model ?? throw new ArgumentNullException(nameof(model));
        Wheels = wheels;
        Year = year;
    }

    public override string ToString()
    {
        return $"Car {{ID={ID}, Make='{Make}', Model='{Model}', Wheels={Wheels}, Year={Year}}}";
    }
}