using System.Collections.Generic;
using System.Threading;
using Avalonia.Controls;

namespace task1;

public partial class MainWindow : Window
{
    public Person Person { get; private set; }
    
    public MainWindow()
    {
        InitializeComponent();

        Person = new("Lukas", 80.0, 23, 99.9, false);

        MainGrid.DataContext = this;
    }
}