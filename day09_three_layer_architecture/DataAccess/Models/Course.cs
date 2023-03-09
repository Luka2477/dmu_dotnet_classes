namespace DataAccess.Models;

internal class Course
{
    private ICollection<Enrollment>? _enrollments;

    public int ID { get; set; }
    public string Title { get; set; }

    public virtual ICollection<Enrollment>? Enrollments
    {
        get => _enrollments;
        set => _enrollments = value;
    }

    public Course(int id, string title, ICollection<Enrollment>? enrollments = null)
    {
        ID = id;
        Title = title ?? throw new ArgumentNullException(nameof(title));
        _enrollments = enrollments;
    }
}