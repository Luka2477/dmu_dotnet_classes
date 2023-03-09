namespace DataTransfer;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Course>? Courses { get; }

    public Student(int id, string name, ICollection<Course>? courses = null)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Courses = courses;
    }
}