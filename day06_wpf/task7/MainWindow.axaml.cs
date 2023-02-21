using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task7;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MenuItem_OnClick(object? sender, RoutedEventArgs e)
    { 
        if (sender == null) return;

        var menuItem = (MenuItem)sender;
        Console.WriteLine(menuItem.Header);
        StatusBar.Text = $"Status: {menuItem.Header} clicked";
    }
}