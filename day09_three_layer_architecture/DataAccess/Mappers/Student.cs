using System.Collections;

namespace DataAccess.Mappers;

internal static class Student
{
    public static DataTransfer.Student Map(Models.Student dataStudent)
    {
        return new DataTransfer.Student(dataStudent.ID, dataStudent.Name, Mappers.Course.Map(dataStudent.Enrollments));
    }

    public static Models.Student Map(DataTransfer.Student student)
    {
        return new Models.Student(student.ID, student.Name, Mappers.Enrollment.Map(student));
    }
    
    public static ICollection<DataTransfer.Student> Map(ICollection<Models.Student> dataStudents)
    {
        return dataStudents.Select(Map).ToList();
    }

    public static ICollection<Models.Student> Map(ICollection<DataTransfer.Student> students)
    {
        return students.Select(Map).ToList();
    }

    public static ICollection<DataTransfer.Student> Map(ICollection<Models.Enrollment> dataEnrollments)
    {
        return dataEnrollments.Select(e => Map(e.Student)).ToList();
    }
}