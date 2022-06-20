namespace Prog_Lab4;

public class Manager: Employee, IWork
{
    public List<Employee> Workers { set; get; }
    
    public Manager(string name, int salary, int exp) : base(name, salary, exp)
    {
        Post = Posts.Менеджер;
        Workers = new List<Employee>();
        Weekends = 2;
    }

    public void ShowWorkers()
    {
        foreach (Employee employee in Workers)
            Console.WriteLine($"{employee.Name}({employee.Post})");
        Console.WriteLine($"Кiлькiсть пiдлеглих: {Workers.Count}");
    }

    public void GiveTask(Employee? employee)
    {
        if(employee.Post == Posts.Менеджер || employee.Post == Posts.Керiвник) return;
        if(Workers.Exists(x => x == employee)) 
            Console.WriteLine($"Менеджер {Name} дав завдання {employee.Name}({employee.Post})");
    }

    public void Work()
    {
        Console.WriteLine($"Менеджер {Name} координує роботу працiвникiв");
    }
}