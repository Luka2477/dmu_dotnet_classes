namespace DataAccess.Mappers;

internal static class Course
{
    public static DataTransfer.Course Map(Models.Course dataCourse)
    {
        return new DataTransfer.Course(dataCourse.CourseID, dataCourse.Title, MapStudents(dataCourse.Students));
    }

    public static Models.Course Map(DataTransfer.Course course)
    {
        return new Models.Course(course.CourseID, course.Title, MapStudents(course.Students));
    }

    public static ICollection<DataTransfer.Course> Map(ICollection<Models.Course> dataCourses)
    {
        return dataCourses.Select(Map).ToList();
    }
    
    public static ICollection<Models.Course> Map(ICollection<DataTransfer.Course> courses)
    {
        return courses.Select(Map).ToList();
    }

    public static ICollection<DataTransfer.Student> MapStudents(ICollection<Models.Student> dataStudents)
    {
        return dataStudents.Select(s => new DataTransfer.Student(s.StudentID, s.Name, null)).ToList();
    }
    
    public static ICollection<Models.Student> MapStudents(ICollection<DataTransfer.Student> students)
    {
        return students.Select(s => new Models.Student(s.StudentID, s.Name, null)).ToList();
    }
}