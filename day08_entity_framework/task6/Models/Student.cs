using System.Collections.ObjectModel;

namespace task6.Models;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    
    public virtual ObservableCollection<Class> Classes { get; }
}