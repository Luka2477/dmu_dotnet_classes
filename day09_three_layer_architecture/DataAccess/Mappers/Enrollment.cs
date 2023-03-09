namespace DataAccess.Mappers;

internal static class Enrollment
{
    public static Models.Enrollment Map(DataTransfer.Course course, DataTransfer.Student student)
    {
        return new Models.Enrollment(course.ID, Mappers.Course.Map(course), student.ID, Mappers.Student.Map(student));
    }

    public static ICollection<Models.Enrollment> Map(DataTransfer.Course course)
    {
        return course.Students.Select(s => Map(course, s)).ToList();
    }

    public static ICollection<Models.Enrollment> Map(DataTransfer.Student student)
    {
        return student.Courses.Select(c => Map(c, student)).ToList();
    }
}