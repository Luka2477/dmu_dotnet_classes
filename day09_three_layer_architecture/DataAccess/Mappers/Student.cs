namespace DataAccess.Mappers;

internal static class Student
{
    public static DataTransfer.Student Map(Models.Student dataStudent)
    {
        return new DataTransfer.Student(dataStudent.StudentID, dataStudent.Name, MapCourses(dataStudent.Courses));
    }

    public static Models.Student Map(DataTransfer.Student student)
    {
        return new Models.Student(student.StudentID, student.Name, MapCourses(student.Courses));
    }

    public static ICollection<DataTransfer.Student> Map(ICollection<Models.Student> dataStudents)
    {
        return dataStudents.Select(Map).ToList();
    }

    public static ICollection<Models.Student> Map(ICollection<DataTransfer.Student> students)
    {
        return students.Select(Map).ToList();
    }

    private static ICollection<DataTransfer.Course> MapCourses(ICollection<Models.Course> dataCourses)
    {
        return dataCourses.Select(c => new DataTransfer.Course(c.CourseID, c.Title, null)).ToList();
    }

    private static ICollection<Models.Course> MapCourses(ICollection<DataTransfer.Course> courses)
    {
        return courses.Select(c => new Models.Course(c.CourseID, c.Title, null)).ToList();
    }
}