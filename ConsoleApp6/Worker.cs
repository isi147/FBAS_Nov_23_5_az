namespace ConsoleApp6;

public class Worker
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateOnly Birthday { get; set; }
    public decimal Salary { get; set; }

    public Worker(Guid id, string name, string surname, DateOnly birthday, decimal salary)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Birthday = birthday;
        Salary = salary;
    }

    public virtual void Work()
    {
        Console.WriteLine("Working");
    }

    public override string ToString() =>
        $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nBirthday:{Birthday}\nSalary:{Salary}";
}
