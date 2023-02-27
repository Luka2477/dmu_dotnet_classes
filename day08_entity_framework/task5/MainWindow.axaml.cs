using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.EntityFrameworkCore;
using task5.DAL;
using task5.Models;

namespace task5;

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

        _context.Owners.Load();
    }

    private void ComboBoxCars_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Car selected = (Car)ComboBoxCars.SelectedItem;
        if (selected == null)
        {
            ListBoxOwners.Items = null;
            MainGrid.DataContext = null;
            return;
        }

        ListBoxOwners.Items = selected.Owners;
        MainGrid.DataContext = selected;
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        _context.SaveChanges();
        ComboBoxCars.Items = null;
        ComboBoxCars.Items = _context.Cars.Local.ToObservableCollection();
    }
}