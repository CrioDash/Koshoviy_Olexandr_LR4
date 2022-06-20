namespace Prog_Lab4;

public abstract class Employee
{
    public enum Posts
    {
        Механiк,
        Iнженер,
        IнженерАрхiтектор,
        Менеджер,
        Керiвник
    }
    public string Name { set; get; }
    public Posts Post { set; get; }
    public int Salary { set; get; }
    public int Exp { set; get; }
    public int Weekends { set; get; }
    public Employee(string name, int salary, int exp)
    {
        Programm.Workers.Add(this);
        Name = name;
        Salary = salary;
        Exp = exp;
    }
}