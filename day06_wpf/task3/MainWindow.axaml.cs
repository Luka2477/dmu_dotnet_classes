using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonHello_OnClick(object? sender, RoutedEventArgs e)
    {
        ButtonHello.Content = "I have been clicked!";
    }
}