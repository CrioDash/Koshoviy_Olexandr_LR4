namespace Prog_Lab4;

public class Engineer:Employee, IWork
{
    public Engineer(string name, int salary, int exp, Manager manager) : base(name, salary, exp)
    {
        Weekends = 2;
        manager.Workers.Add(this);
        Post = Posts.Iнженер;
    }

    public void ShowWeekends()
    {
        Console.WriteLine($"{Post} {Name} має {Weekends*52} вихiдних в роцi");
    }
    
    public void Work()
    {
        Console.WriteLine($"Iнженер {Name} перевiряє схему проекту");
    }
    
}