using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace task3;

public partial class MainWindow : Window
{
    private PersonDataContext _personDataContext;
    
    public MainWindow()
    {
        InitializeComponent();

        _personDataContext = new("Lukas", 80.0, 23, 99.9, false);
        MainGrid.DataContext = _personDataContext;
    }

    /*private void TbName_OnTextInput(object? sender, TextInputEventArgs e)
    {
        if (sender == null) return;
        
        var textBox = (TextBox)sender;
        _personDataContext.Name = textBox.Text;
    }

    private void TbWeight_OnTextInput(object? sender, TextInputEventArgs e)
    {
        if (sender == null) return;
        
        var textBox = (TextBox)sender;
        _personDataContext.Weight = double.Parse(textBox.Text);
    }
    
    private void TbAge_OnTextInput(object? sender, TextInputEventArgs e)
    {
        if (sender == null) return;
        
        var textBox = (TextBox)sender;
        _personDataContext.Age = int.Parse(textBox.Text);
    }
    
    private void TbScore_OnTextInput(object? sender, TextInputEventArgs e)
    {
        if (sender == null) return;
        
        var textBox = (TextBox)sender;
        _personDataContext.Score = double.Parse(textBox.Text);
    }

    private void CbAccepted_OnPropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
    {
        if (sender == null) return;
        
        var checkBox = (CheckBox)sender;
        _personDataContext.Accepted = checkBox.IsChecked ?? false;
    }*/
    
    private void BtnPrint_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine(_personDataContext);
    }
}