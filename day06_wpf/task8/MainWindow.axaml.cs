using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task8;

public partial class MainWindow : Window
{
    private readonly List<string> _checkBoxes = new();
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RadioButton_Checked(object? sender, RoutedEventArgs e)
    {
        if (sender == null) return;

        var radioButton = (RadioButton)sender;
        LabelRadioButtons.Content = radioButton.Content;
    }

    private void CheckBox_Checked(object? sender, RoutedEventArgs e)
    {
        if (sender == null) return;

        var checkBox = (CheckBox)sender;
        _checkBoxes.Add(checkBox.Content.ToString() ?? string.Empty);
        LabelCheckBoxes.Content = string.Join(", ", _checkBoxes);
    }

    private void CheckBox_Unchecked(object? sender, RoutedEventArgs e)
    {
        if (sender == null) return;

        var checkBox = (CheckBox)sender;
        _checkBoxes.Remove(checkBox.Content.ToString() ?? string.Empty);
        LabelCheckBoxes.Content = string.Join(", ", _checkBoxes);
    }
}