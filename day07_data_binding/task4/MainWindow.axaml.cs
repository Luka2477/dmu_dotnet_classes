using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace task4;

public partial class MainWindow : Window
{
    private readonly ObservableCollection<PersonDataContext> _persons;

    public MainWindow()
    {
        InitializeComponent();

        _persons = new ObservableCollection<PersonDataContext>
        {
            new PersonDataContext("Lukas", 80.5, 23, 99.9, true),
            new PersonDataContext("Mads", 75.0, 26, 75.0, true),
            new PersonDataContext("Mike", 90.0, 28, 50.0, false)
        };
        LbPersons.DataContext = _persons;
    }

    private void BtnAddPerson_OnClick(object? sender, RoutedEventArgs e)
    {
        _persons.Add(new PersonDataContext("New Person", 10.0, 10, 10.0, true));
    }
}