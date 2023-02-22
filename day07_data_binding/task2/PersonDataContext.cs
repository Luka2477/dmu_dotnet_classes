using System;
using System.ComponentModel;

namespace task2;

public class PersonDataContext : INotifyPropertyChanged
{
    private string _name;
    private double _weight;
    private int _age;
    private double _score;
    private bool _accepted;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    public double Weight
    {
        get => _weight;
        set
        {
            _weight = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Weight)));
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            _age = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
        }
    }

    public double Score
    {
        get => _score;
        set
        {
            _score = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Score)));
        }
    }

    public bool Accepted
    {
        get => _accepted;
        set
        {
            _accepted = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Accepted)));
        }
    }

    public PersonDataContext(string name, double weight, int age, double score, bool accepted)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
        _weight = weight;
        _age = age;
        _score = score;
        _accepted = accepted;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}