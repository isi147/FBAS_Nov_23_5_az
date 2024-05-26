
namespace ConsoleApp6;

public class Police : Worker
{
    public Rank Rank { get; set; }
    public Police(Guid id, string name, string surname, DateOnly birthday, decimal salary, Rank rank) : base(id, name, surname, birthday, salary)
    {
        Rank = rank;
    }
    public override void Work()
    {
        Console.WriteLine("Maintain public order");
    }

    public override string ToString()
    {
        return base.ToString() + "\nRank:" + Rank;
    }




}
