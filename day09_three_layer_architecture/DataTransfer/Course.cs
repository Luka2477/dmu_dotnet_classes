namespace DataTransfer;

public class Course
{
    public int ID { get; set; }
    public string Title { get; set; }
    public ICollection<Student>? Students { get; }

    public Course(int id, string title, ICollection<Student>? students = null)
    {
        ID = id;
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Students = students;
    }
}