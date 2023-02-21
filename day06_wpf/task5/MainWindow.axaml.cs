using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task5;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonTop_OnClick(object? sender, RoutedEventArgs e)
    {
        var temp = LabelTopLeft.Content.ToString() ?? "😅";
        LabelTopLeft.Content = LabelTopRight.Content;
        LabelTopRight.Content = temp;
    }

    private void ButtonBottom_OnClick(object? sender, RoutedEventArgs e)
    {
        var temp = LabelBottomLeft.Content.ToString() ?? "😅";
        LabelBottomLeft.Content = LabelBottomRight.Content;
        LabelBottomRight.Content = temp;
    }
}