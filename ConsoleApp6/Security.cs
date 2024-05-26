
namespace ConsoleApp6;

public sealed class Security : Worker
{
    public string Gun { get; set; }
    public Security(Guid id, string name, string surname, DateOnly birthday, decimal salary, string gun) : base(id, name, surname, birthday, salary)
    {
        Gun = gun;
    }
    public override void Work()
    {
        Console.WriteLine("Provide security");
    }
    public override string ToString()
    {
        return base.ToString() + "\nGun:" + Gun;
    }




}
