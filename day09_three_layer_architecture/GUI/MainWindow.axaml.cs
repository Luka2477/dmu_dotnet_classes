using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GUI;

public partial class MainWindow : Window
{
    private Contexts.MainContext _context;
    
    public MainWindow()
    {
        InitializeComponent();
        
        _context = new Contexts.MainContext("<-->");
        LsbStudents.Items = _context.Students;
        LsbCourses.Items = _context.Courses;
        TxbRelation.Text = _context.Relation;
    }

    private void ResetStudents()
    {
        _context.Courses.Clear();
        _context.Courses.Add(BusinessLogic.Course.Get());
        
        if (LsbCourses.SelectedItem == null) _context.Relation = "<-->";
    }

    private void ResetCourses()
    {
        _context.Students.Clear();
        _context.Students.Add(BusinessLogic.Student.Get());
    }

    private void StudentsClearSelection(object? sender, RoutedEventArgs e)
    {
        LsbStudents.SelectedItem = null;
        ResetStudents();
        
        if (LsbStudents.SelectedItem == null) _context.Relation = "<-->";
    }

    private void CoursesClearSelection(object? sender, RoutedEventArgs e)
    {
        LsbCourses.SelectedItem = null;
        ResetCourses();
    }

    private void LsbStudents_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Contexts.StudentContext selected = (Contexts.StudentContext)LsbStudents.SelectedItem;
        if (selected == null)
        {
            ResetStudents();
            return;
        }

        _context.Courses.Clear();
        _context.Courses.Add(BusinessLogic.Student.Get(selected.Student.StudentID).Courses);
        _context.Relation = "--->";
    }

    private void LsbCourses_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Contexts.CourseContext selected = (Contexts.CourseContext)LsbCourses.SelectedItem;
        if (selected == null)
        {
            ResetCourses();
            return;
        }

        _context.Students.Clear();
        _context.Students.Add(BusinessLogic.Course.Get(selected.Course.CourseID).Students);
        _context.Relation = "<---";
    }
}