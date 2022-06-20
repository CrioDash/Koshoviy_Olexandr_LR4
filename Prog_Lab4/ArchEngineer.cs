namespace Prog_Lab4;

public class ArchEngineer:Engineer, IWork
{
    public ArchEngineer(string name, int salary, int exp, Manager manager) : base(name, salary, exp, manager)
    {
        Weekends = 3;
        Post = Posts.IнженерАрхiтектор;
    }
    
    public void Work()
    {
        Console.WriteLine($"Iнженер-архiтектор {Name} розроблює схему проекту");
    }
    
}