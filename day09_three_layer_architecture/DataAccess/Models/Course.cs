namespace DataAccess.Models;

internal class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    
    public ICollection<Student> Students { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public Course() { }

    public Course(int courseID, string title, ICollection<Student> students)
    {
        CourseID = courseID;
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Students = students;
    }
}