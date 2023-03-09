namespace DataAccess.Models;

internal class Enrollment
{
    private Student? _student;
    private Course? _course;
    
    public int ID { get; set; }
    public int StudentID { get; set; }
    public virtual Student? Student { get => _student; set => _student = value; }
    public int CourseID { get; set; }
    public virtual Course? Course { get => _course; set => _course = value; }

    public Enrollment(int courseID, Course course, int studentID, Student student)
    {
        CourseID = courseID;
        _course = course;
        StudentID = studentID;
        _student = student;
    }
}