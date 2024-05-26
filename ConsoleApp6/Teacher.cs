
namespace ConsoleApp6;

public class Teacher : Worker
{
    public string Faculty { get; set; }
    public Teacher(Guid id, string name, string surname, DateOnly birthday, decimal salary, string faculty) : base(id, name, surname, birthday, salary)
    {
        Faculty = faculty;
    }
    public override void Work()
    {
        Console.WriteLine("Educate people");
    }

    public override string ToString()
    {
        return base.ToString() + "\nFaculty:" + Faculty;
    }

}
