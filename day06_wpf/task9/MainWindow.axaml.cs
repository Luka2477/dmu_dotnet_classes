using System;
using System.Collections.Generic;
using System.ComponentModel;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task9;

public partial class MainWindow : Window
{
    private readonly List<string> _leftItems = new();
    private readonly List<string> _rightItems = new();
    
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(_leftItems, _rightItems);
    }

    private void AddLeft_OnClick(object? sender, RoutedEventArgs e)
    {
        string text = TbLeft.Text.Trim();
        if (text.Equals(string.Empty)) return;

        _leftItems.Add(text);
    }

    private void AddRight_OnClick(object? sender, RoutedEventArgs e)
    {
        string text = TbRight.Text.Trim();
        if (text.Equals(string.Empty)) return;

        _rightItems.Add(text);
    }

    private void ClearLeft_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void ClearRight_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void TransferRight_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void TransferLeft_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }
    
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<string> _leftItems;
        private List<string> _rightItems;

        public MainWindowViewModel(List<string> leftItems, List<string> rightItems)
        {
            _leftItems = leftItems;
            _rightItems = rightItems;
        }

        public List<string> LeftItems => _leftItems;
        public List<string> RightItems => _rightItems;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}