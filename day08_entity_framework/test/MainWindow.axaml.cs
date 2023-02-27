using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.EntityFrameworkCore;
using test.DAL;
using test.Models;

namespace test;

public partial class MainWindow : Window
{
    private readonly PersonContext _context = new();
    
    public MainWindow()
    {
        InitializeComponent();

        Console.WriteLine($"Database created: {_context.Database.EnsureCreated()}");
        Console.WriteLine($"Database connected: {_context.Database.CanConnect()}");
        
        _context.Persons.Load();
        LbPersons.Items = _context.Persons.Local.ToObservableCollection();
        
        _context.Houses.Load();

        _context.Pets.Load();
    }

    private void BtnAddNewPerson_OnClick(object? sender, RoutedEventArgs e)
    {
        Person p = new("Some kind of name");
        _context.Persons.Add(p);
        _context.SaveChanges();
    }

    private void BtnRemove_OnClick(object? sender, RoutedEventArgs e)
    {
        Person selected = (Person)LbPersons.SelectedItem;
        if (selected == null) return;

        _context.Persons.Remove(selected);
        _context.SaveChanges();
    }

    private void LbPersons_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Person selected = (Person)LbPersons.SelectedItem;
        if (selected == null)
        {
            TbckHouse.Text = "";
            LbPets.Items = null;
            return;
        }

        TbckHouse.Text = selected.House?.ToString() ?? "They're kinda poor...";
        LbPets.Items = selected.Pets;
    }
}