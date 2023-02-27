using System;
using Avalonia.Controls;
using task6.DAL;

namespace task6;

public partial class MainWindow : Window
{
    private readonly SchoolContext _context = new();

    public MainWindow()
    {
        InitializeComponent();

        Console.WriteLine($"Database created: {_context.Database.EnsureCreated()}");
        Console.WriteLine($"Database connected: {_context.Database.CanConnect()}");
    }
}