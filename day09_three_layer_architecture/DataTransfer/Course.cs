namespace DataTransfer;

public class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    
    public ICollection<Student> Students { get; set; }

    public Course(int courseID, string title, ICollection<Student> students)
    {
        CourseID = courseID;
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Students = students;
    }

    public override string ToString()
    {
        return $"{CourseID}: {Title}";
    }
}