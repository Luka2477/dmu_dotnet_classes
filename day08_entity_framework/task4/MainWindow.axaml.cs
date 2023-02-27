using System;
using System.Linq;
using Avalonia.Controls;
using Microsoft.EntityFrameworkCore;
using task4.DAL;
using task4.Models;

namespace task4;

public partial class MainWindow : Window
{
    private readonly CarContext _context = new();

    public MainWindow()
    {
        InitializeComponent();

        Console.WriteLine($"Database created: {_context.Database.EnsureCreated()}");
        Console.WriteLine($"Database connected: {_context.Database.CanConnect()}");
        
        _context.Cars.Load();
        ComboBoxCars.Items = _context.Cars.Local.ToObservableCollection();
        ComboBoxCars.SelectedIndex = 0;

        _context.Owners.Load();
        ListBoxOwners.Items = _context.Cars.ToList()[0].Owners;
    }

    private void ComboBoxCars_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Car selected = (Car)ComboBoxCars.SelectedItem;
        if (selected == null)
        {
            ListBoxOwners.Items = null;
            return;
        }

        ListBoxOwners.Items = selected.Owners;
    }
}