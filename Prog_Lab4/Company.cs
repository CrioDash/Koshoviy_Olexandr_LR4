namespace Prog_Lab4;

public class Company
{
    private List<Employee> Workers { set; get; }
    public string Name { set; get; }
    public Company(string name)
    {
        Name = name;
        Workers = new List<Employee>();
    }

    public void AddWorker(Employee employee)
    {
        Workers.Add(employee);
        Console.WriteLine($"Працiвника {employee.Name}({employee.Post}) найнято в компанiю {Name}");
    }

    public void KickWorker(Employee employee)
    {
        Workers.Add(employee);
        Console.WriteLine($"Працiвника {employee.Name}({employee.Post}) звiльнено з компанiї {Name}");
    }

    public void ShowSalaries()
    {
        foreach (Employee employee in Workers)
        {
            Console.WriteLine($"Зарплатня {employee.Name}({employee.Post}) - {employee.Salary}");
        }
    }

    public void MediumSalary(Employee.Posts post)
    {
        int count = 0;
        int med = 0;
        foreach (Employee employee in Workers)
            if (employee.Post == post)
            {
                med += employee.Salary;
                count++;
            }
        if(med == 0)
            Console.WriteLine($"В компанiї {Name} немає {post}");
        else
        Console.WriteLine($"Середня зарплата {post} в компанiї {Name} - {med/count}");
    }
}