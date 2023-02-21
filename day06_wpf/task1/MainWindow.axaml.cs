using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CheckBox_Clicked(object? sender, RoutedEventArgs e)
    {
        ButtonHello.IsVisible = CheckBoxHello.IsChecked ?? false;
    }
}