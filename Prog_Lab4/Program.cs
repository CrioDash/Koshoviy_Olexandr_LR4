namespace Prog_Lab4
{
    class Programm
    {
        public static List<Employee> Workers = new List<Employee>();
        static void Main()
        {
            Ceo ceo = new Ceo("Влад", 40000, 10);
            ceo.Work();
            Manager manager = new Manager("Микола", 30000, 7);
            manager.Work();
            ArchEngineer archEngineer = new ArchEngineer("Петро", 28000, 15, manager);
            archEngineer.Work();
            archEngineer.ShowWeekends();
            Engineer engineer = new Engineer("Степан", 23000, 8, manager);
            engineer.Work();
            engineer.ShowWeekends();
            Mechanic mechanic = new Mechanic("Гриша", 15000, 2, manager);
            mechanic.Work();
            manager.ShowWorkers();
            manager.GiveTask(engineer);
            ShowSalaries();
            ceo.Promote(engineer);
        }
        
        public static void ShowSalaries()
        {
            foreach (Employee employee in Workers)
            {
                Console.WriteLine($"Зарплатня {employee.Name}({employee.Post}) - {employee.Salary}");
            }
        }
    }
} 