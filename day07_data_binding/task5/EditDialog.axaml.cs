using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace task5;

public partial class EditDialog : Window
{
    public EditDialog()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void BtnSave_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}