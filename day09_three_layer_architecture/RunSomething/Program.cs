// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;

List<DataTransfer.Student> students = BusinessLogic.Student.Get().ToList();
foreach (var s in students)
{
    Console.WriteLine(s);
}

// Something.Contexts.Context context = new();
//
// Console.WriteLine("Students:");
// foreach (var s in context.Students.Include(s => s.Courses))
// {
//     Console.WriteLine("  " + s);
//     foreach (var c in s.Courses)
//     {
//         Console.WriteLine("    " + c);
//     }
// }
//
// Console.WriteLine("Courses:");
// foreach (var c in context.Courses.Include(c => c.Students))
// {
//     Console.WriteLine("  " + c);
//     foreach (var s in c.Students)
//     {
//         Console.WriteLine("    " + s);
//     }
// }
//
// Console.WriteLine();
// Console.WriteLine("After remove...");
// Console.WriteLine();
//
// Something.Contexts.Course course = context.Courses.Include(c => c.Students).Single(c => c.CourseID == 1);
// Something.Contexts.Student student = context.Students.Include(s => s.Courses).Single(s => s.StudentID == 1);
// List<Something.Contexts.Course> courses =
//     student.Courses.ToList();
// courses.Remove(course);
// student.Courses = courses;
// context.SaveChanges();
//
// Console.WriteLine("Students:");
// foreach (var s in context.Students.Include(s => s.Courses))
// {
//     Console.WriteLine("  " + s);
//     foreach (var c in s.Courses)
//     {
//         Console.WriteLine("    " + c);
//     }
// }
//
// Console.WriteLine("Courses:");
// foreach (var c in context.Courses.Include(c => c.Students))
// {
//     Console.WriteLine("  " + c);
//     foreach (var s in c.Students)
//     {
//         Console.WriteLine("    " + s);
//     }
// }