using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GUI.Contexts;

public class MainContext : INotifyPropertyChanged
{
    private string _relation;

    public ObservableCollection<StudentContext> Students { get; set; }
    public ObservableCollection<CourseContext> Courses { get; set; }

    public string Relation
    {
        get => _relation;
        set => SetField(ref _relation, value);
    }

    public MainContext(string relation = "")
    {
        Students = new ObservableCollection<StudentContext>().Add(BusinessLogic.Student.Get());
        Courses = new ObservableCollection<CourseContext>().Add(BusinessLogic.Course.Get());
        _relation = relation ?? throw new ArgumentNullException(nameof(relation));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}