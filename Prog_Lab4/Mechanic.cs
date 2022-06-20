namespace Prog_Lab4;

public class Mechanic:Employee, IWork
{
    public Mechanic(string name, int salary, int exp, Manager manager) : base(name, salary, exp)
    {
        Weekends = 2;
        manager.Workers.Add(this);
        Post = Posts.Механiк;
    }
    
    public void Work()
    {
        Console.WriteLine($"Механiк {Name} працює над створенням проекту");
    }
}