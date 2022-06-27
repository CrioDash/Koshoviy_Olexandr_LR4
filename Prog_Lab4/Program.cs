namespace Prog_Lab4
{
    class Programm
    {
        static void Main()
        {
            Company company = new Company("Сiгма тiм");
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
            Mechanic mechanic1 = new Mechanic("Гриша", 15000, 2, manager);
            mechanic1.Work();
            Mechanic mechanic2 = new Mechanic("Вася", 16500, 2, manager);
            manager.ShowWorkers();
            manager.GiveTask(engineer);
            ceo.Promote(engineer);
            company.AddWorker(ceo);
            company.AddWorker(manager);
            company.AddWorker(archEngineer);
            company.AddWorker(engineer);
            company.AddWorker(mechanic1);
            company.AddWorker(mechanic2);
            company.ShowSalaries();
            company.MediumSalary(Employee.Posts.Механiк);
        }
    }
} 