using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GUI.Contexts;

public class CourseContext : INotifyPropertyChanged
{
    private DataTransfer.Course _course;

    public DataTransfer.Course Course
    {
        get => _course;
        set => SetField(ref _course, value);
    }

    public CourseContext(DataTransfer.Course course)
    {
        _course = course ?? throw new ArgumentNullException(nameof(course));
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

    public override string ToString()
    {
        return _course.ToString();
    }
}