using System;

    class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;

        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        public void ModifySalary(double newSalary)
        {
            salary = newSalary;
            Console.WriteLine("\nUpdated Salary: " + salary);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }

        public void DisplayManagerDetails()
        {
            Console.WriteLine("Manager ID: " + employeeID);
            Console.WriteLine("Manager Department: " + department);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int employeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee employee1 = new Employee(employeeID, department, salary);
            employee1.DisplayEmployeeDetails();

            Console.Write("\nEnter new salary to modify: ");
            double newSalary = Convert.ToDouble(Console.ReadLine());
            employee1.ModifySalary(newSalary);

            Manager manager1 = new Manager(employeeID, department, salary);
            manager1.DisplayManagerDetails();

            Console.Write("\nEnter new salary to modify: ");
            double newManagerSalary = Convert.ToDouble(Console.ReadLine());
            manager1.ModifySalary(newManagerSalary);
        }
    }

