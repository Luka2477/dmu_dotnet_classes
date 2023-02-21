using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task6;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DockButton_OnClick(object? sender, RoutedEventArgs e)
    { 
        if (sender == null) return;

        var button = (Button)sender;
        TextBoxCenter.Text += button.Content.ToString() + "\n";
    }
}