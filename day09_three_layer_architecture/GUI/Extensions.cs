using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GUI;

public static class Extensions
{
    public static ObservableCollection<Contexts.StudentContext> Add(
        this ObservableCollection<Contexts.StudentContext> oc, ICollection<DataTransfer.Student> students)
    {
        students.ToList().ForEach(s => oc.Add(new Contexts.StudentContext(s)));
        return oc;
    }
    
    public static ObservableCollection<Contexts.CourseContext> Add(
        this ObservableCollection<Contexts.CourseContext> oc, ICollection<DataTransfer.Course> courses)
    {
        courses.ToList().ForEach(c => oc.Add(new Contexts.CourseContext(c)));
        return oc;
    }
}