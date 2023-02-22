using Avalonia.Controls;
using Avalonia.Input;

namespace task2;

public partial class MainWindow : Window
{
    public PersonDataContext personDataContext;
    
    public MainWindow()
    {
        InitializeComponent();

        personDataContext = new("Lukas", 80.0, 23, 99.9, false);
        MainGrid.DataContext = personDataContext;
    }

    private void InputElement_OnTextInput(object? sender, TextInputEventArgs e)
    {
        if (sender == null) return;
        
        var textBox = (TextBox)sender;
        personDataContext.Name = textBox.Text;
    }
}