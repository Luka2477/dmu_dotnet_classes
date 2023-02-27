using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.EntityFrameworkCore;
using task3.DAL;
using task3.Models;

namespace task3;

public partial class MainWindow : Window
{
    private readonly CarContext _context = new();

    public MainWindow()
    {
        InitializeComponent();

        Console.WriteLine($"Database created: {_context.Database.EnsureCreated()}");
        Console.WriteLine($"Database connected: {_context.Database.CanConnect()}");

        _context.Cars.Load();
        LbCars.Items = _context.Cars.Local.ToObservableCollection();

        _context.Owners.Load();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        _context.Cars.Add(new Car("Skoda", "Octavia", 4, 2020));
        _context.SaveChanges();
    }

    private void LbCars_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Car selected = (Car)LbCars.SelectedItem;
        if (selected == null)
        {
            LbOwners.Items = null;
            return;
        }

        LbOwners.Items = selected.Owners;
    }
}