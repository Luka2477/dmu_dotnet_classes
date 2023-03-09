namespace DataAccess.Models;

internal class Student
{
    private ICollection<Enrollment>? _enrollments;

    public int ID { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Enrollment>? Enrollments
    {
        get => _enrollments;
        set => _enrollments = value;
    }

    public Student(int id, string name, ICollection<Enrollment>? enrollments = null)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        _enrollments = enrollments;
    }
}