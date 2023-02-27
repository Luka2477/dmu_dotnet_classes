using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using task1.DAL;
using task1.Models;

namespace task1;

public partial class MainWindow : Window
{
    private readonly CarContext _context = new();

    public MainWindow()
    {
        InitializeComponent();

        Console.WriteLine($"Database created: {_context.Database.EnsureCreated()}");
        Console.WriteLine($"Database connected: {_context.Database.CanConnect()}");

        LbCars.Items = _context.Cars;
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        _context.Cars.Add(new Car("Skoda", "Octavia", 4));
        _context.SaveChanges();

        LbCars.Items = null;
        LbCars.Items = _context.Cars;
    }
}