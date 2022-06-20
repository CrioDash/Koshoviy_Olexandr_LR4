namespace Prog_Lab4;

public class Ceo:Employee, IWork
{
    public Ceo(string name, int salary, int exp) : base(name, salary, exp)
    {
        Post = Posts.Керiвник;
        Weekends = 3;
    }
    
    public void Promote(Employee? employee)
    {
        if (Check(employee))
        {
            Console.WriteLine($"{employee.Name} звiльнено");
            return;
        }
        if (employee.Post == Posts.Керiвник)
        {
            Console.WriteLine("Не можна пiдвищити керiвника");
            return;
        }
        employee.Post ++;
        Console.WriteLine($"{employee.Name} отримав посаду '{employee.Post}'");
        
    }
    
    public void Demote(Employee? employee)
    {
        if (Check(employee))
        {
            Console.WriteLine($"{employee.Name} звiльнено");
            return;
        }
        if (employee.Post == Posts.Механiк)
        {
            Console.WriteLine($"{employee.Name} звiльнено");
            employee = null;
            return;
        }
        employee.Post --;
        Console.WriteLine($"{employee.Name} отримав посаду '{employee.Post}'");
    }

    public void Work()
    {
       Console.WriteLine($"Керiвник {Name} розпочав роботу над проектом");
    }

    private bool Check(Employee? employee)
    {
        return employee == null;
    }
}