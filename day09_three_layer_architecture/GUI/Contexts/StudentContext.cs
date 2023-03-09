using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GUI.Contexts;

public class StudentContext : INotifyPropertyChanged
{
    private DataTransfer.Student _student;

    public DataTransfer.Student Student
    {
        get => _student;
        set => SetField(ref _student, value);
    }

    public StudentContext(DataTransfer.Student student)
    {
        _student = student ?? throw new ArgumentNullException(nameof(student));
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
        return _student.ToString();
    }
}