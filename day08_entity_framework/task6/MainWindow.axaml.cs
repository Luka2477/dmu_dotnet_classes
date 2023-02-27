using System;
using Avalonia.Controls;
using Microsoft.EntityFrameworkCore;
using task6.DAL;
using task6.Models;

namespace task6;

public partial class MainWindow : Window
{
    private readonly SchoolContext _context = new();

    public MainWindow()
    {
        InitializeComponent();

        Console.WriteLine($"Database created: {_context.Database.EnsureCreated()}");
        Console.WriteLine($"Database connected: {_context.Database.CanConnect()}");
        
        _context.Students.Load();
        ListBoxStudents.Items = _context.Students.Local.ToObservableCollection();
        
        _context.Classes.Load();
    }

    private void ListBoxStudents_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Student selected = (Student)ListBoxStudents.SelectedItem;
        if (selected == null)
        {
            ListBoxClasses.Items = null;
            ListBoxExtra.Items = null;
            return;
        }

        ListBoxClasses.Items = selected.Classes;
    }

    private void ListBoxClasses_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Class selected = (Class)ListBoxClasses.SelectedItem;
        if (selected == null)
        {
            ListBoxExtra.Items = null;
            return;
        }

        ListBoxExtra.Items = selected.Students;
    }
}