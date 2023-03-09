namespace DataAccess.Models;

internal class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    
    public ICollection<Course> Courses { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public Student() { }

    public Student(int studentID, string name, ICollection<Course> courses)
    {
        StudentID = studentID;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Courses = courses;
    }
}