//using System;

//class Employee
//{
//    public string Name { get; set; }
//    public int Id { get; set; }
//    public double Salary { get; set; }

//    public Employee(string name, int id, double salary)
//    {
//        Name = name;
//        Id = id;
//        Salary = salary;
//    }

//    public virtual void DisplayDetails()
//    {
//        Console.WriteLine("Name: " + Name);
//        Console.WriteLine("ID: " + Id);
//        Console.WriteLine("Salary: " + Salary);
//    }
//}

//class Manager : Employee
//{
//    public int TeamSize { get; set; }

//    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
//    {
//        TeamSize = teamSize;
//    }

//    public override void DisplayDetails()
//    {
//        base.DisplayDetails();
//        Console.WriteLine("Team Size: " + TeamSize);
//    }
//}

//class Developer : Employee
//{
//    public string ProgrammingLanguage { get; set; }

//    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
//    {
//        ProgrammingLanguage = programmingLanguage;
//    }

//    public override void DisplayDetails()
//    {
//        base.DisplayDetails();
//        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
//    }
//}

//class Intern : Employee
//{
//    public int DurationMonths { get; set; }

//    public Intern(string name, int id, double salary, int durationMonths) : base(name, id, salary)
//    {
//        DurationMonths = durationMonths;
//    }

//    public override void DisplayDetails()
//    {
//        base.DisplayDetails();
//        Console.WriteLine("Internship Duration (Months): " + DurationMonths);
//    }
//}

//class Employee
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Manager's name: ");
//        string managerName = Console.ReadLine();
//        Console.Write("Enter Manager's ID: ");
//        int managerId = int.Parse(Console.ReadLine());
//        Console.Write("Enter Manager's Salary: ");
//        double managerSalary = double.Parse(Console.ReadLine());
//        Console.Write("Enter Manager's Team Size: ");
//        int teamSize = int.Parse(Console.ReadLine());

//        Console.Write("Enter Developer's name: ");
//        string devName = Console.ReadLine();
//        Console.Write("Enter Developer's ID: ");
//        int devId = int.Parse(Console.ReadLine());
//        Console.Write("Enter Developer's Salary: ");
//        double devSalary = double.Parse(Console.ReadLine());
//        Console.Write("Enter Developer's Programming Language: ");
//        string programmingLanguage = Console.ReadLine();

//        Console.Write("Enter Intern's name: ");
//        string internName = Console.ReadLine();
//        Console.Write("Enter Intern's ID: ");
//        int internId = int.Parse(Console.ReadLine());
//        Console.Write("Enter Intern's Salary: ");
//        double internSalary = double.Parse(Console.ReadLine());
//        Console.Write("Enter Internship Duration (Months): ");
//        int durationMonths = int.Parse(Console.ReadLine());

//        Employee manager = new Manager(managerName, managerId, managerSalary, teamSize);
//        Employee developer = new Developer(devName, devId, devSalary, programmingLanguage);
//        Employee intern = new Intern(internName, internId, internSalary, durationMonths);

//        Console.WriteLine("\nEmployee Details:\n");
//        manager.DisplayDetails();
//        Console.WriteLine();
//        developer.DisplayDetails();
//        Console.WriteLine();
//        intern.DisplayDetails();
//    }
//}
