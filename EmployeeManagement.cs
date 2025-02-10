//using System;
//using System.Collections.Generic;

//abstract class Employee
//{ 

//    private int employeeId { get;  set; }
//    public string name { get; private set; }
//    protected double baseSalary { get; set; }
//    public Employee(int id, string name, double salary)
//    {
//        this.employeeId = id;
//        this.name = name ?? "Unknown";  
//        this.baseSalary = salary;
//    }

//    public  abstract double CalculateSalary();


//    public void display() {

//        Console.WriteLine("Id : " + employeeId + " name : " + name + "  baseSalary :  " + baseSalary);
    
//    }




//}

//interface IDepartment
//{


//    void AssignDepartment(string Department);
//    string GetDepartment();
//}

//class FullTimeEmployee : Employee, IDepartment 

//{
//    private string department;

//    public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }

//    public override double CalculateSalary()
//    {
//        return baseSalary;
//    }

//    public void AssignDepartment(string dept) { 
//        department= dept ?? "Not Assigned";
    
//    }

//    public string GetDepartment() {

//        return department;


//}


//    class PartTimeEmployee : Employee, IDepartment
//    {



//        private int workHours { get; set; }
//        private double hourlyRate { get; set; }
//        private string department { get; set; }

//        public PartTimeEmployee(int id, string name, double hourlyRate, int workHours) : base(id, name, 0)
//        {
//            this.hourlyRate = hourlyRate;
//            this.workHours = workHours;
//        }
//        public override double CalculateSalary()
//        {
//            return hourlyRate * workHours;


//        }

//        public void AssignDepartment(string dept)
//        {
//            department = dept ?? "Not Assigned";

//        }

//        public string GetDepartment()
//        {

//            return department;


//        }
//    }
//        class EmployeeManagement
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> employee = new List<Employee>();

//            Console.WriteLine("enter thr no. of employees");

//            int numEmployee=int.Parse(Console.ReadLine());

//            for(int i = 0; i < numEmployee; i++) {
//                Console.WriteLine("enter Full/Part");
//                string type=Console.ReadLine();

//                Console.WriteLine("enter ID");
//                int id=int.Parse(Console.ReadLine());



//                Console.WriteLine("enter Name");
//                String name=Console.ReadLine();

//                if (type == "Full")
//                {
//                    Console.WriteLine("Enter Salary");
//                    int salary=int.Parse(Console.ReadLine());
//                    employee.Add(new FullTimeEmployee(id, name, salary));
//                }
//                else if (type == "part")
//                {
//                    Console.Write("Enter Hourly Rate: ");
//                    double hourlyRate = double.Parse(Console.ReadLine());
//                    Console.Write("Enter Work Hours: ");
//                    int workHours = int.Parse(Console.ReadLine());
//                    employee.Add(new PartTimeEmployee(id, name, hourlyRate, workHours));
//                }
//            }


//            foreach (var emp in employee)
//            {
//                Console.Write($"Enter department for {emp.GetType().Name} {emp.name}: ");
//                string department = Console.ReadLine();
//                ((IDepartment)emp).AssignDepartment(department);
//            }


//            Console.WriteLine("\nEmployee Details:");
//            foreach (var emp in employee)
//            {
//                emp.display(); 
//                Console.WriteLine("Department: " + ((IDepartment)emp).GetDepartment());
//                Console.WriteLine("Calculated Salary: " + emp.CalculateSalary());
//                Console.WriteLine();
//            }
//        }
//    }
//}
