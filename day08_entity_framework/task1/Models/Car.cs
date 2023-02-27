using System;

namespace task1.Models;

public class Car
{
    public int ID { get; set; }
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public int Wheels { get; set; }

    public Car()
    {
    }
    
    public Car(string make, string model, int wheels)
    {
        Make = make ?? throw new ArgumentNullException(nameof(make));
        Model = model ?? throw new ArgumentNullException(nameof(model));
        Wheels = wheels;
    }

    public override string ToString()
    {
        return $"Car {{ID={ID}, Make='{Make}', Model='{Model}', Wheels={Wheels}}}";
    }
}