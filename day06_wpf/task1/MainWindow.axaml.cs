using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender == null) return;
        
        Button button = (Button)sender;
        button.Content = "You clicked me!";
    }
}