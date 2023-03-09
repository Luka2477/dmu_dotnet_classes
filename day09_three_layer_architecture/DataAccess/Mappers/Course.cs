using System.Collections;

namespace DataAccess.Mappers;

internal static class Course
{
    public static DataTransfer.Course Map(Models.Course dataCourse)
    {
        return new DataTransfer.Course(dataCourse.ID, dataCourse.Title, Mappers.Student.Map(dataCourse.Enrollments));
    }

    public static Models.Course Map(DataTransfer.Course course)
    {
        return new Models.Course(course.ID, course.Title, Mappers.Enrollment.Map(course));
    }

    public static ICollection<DataTransfer.Course> Map(ICollection<Models.Course> dataCourses)
    {
        return dataCourses.Select(Map).ToList();
    }

    public static ICollection<Models.Course> Map(ICollection<DataTransfer.Course> courses)
    {
        return courses.Select(Map).ToList();
    }

    public static ICollection<DataTransfer.Course> Map(ICollection<Models.Enrollment>? dataEnrollments)
    {
        return dataEnrollments.Select(e => Map(e.Course)).ToList();
    }
}