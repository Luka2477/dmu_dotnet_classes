using System;

namespace task1;

public class Person
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }
    public bool Accepted { get; set; }

    public Person(string name, double weight, int age, double score, bool accepted)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Weight = weight;
        Age = age;
        Score = score;
        Accepted = accepted;
    }
}