//using System;

//    class Student1
//    {
//        public int rollNumber;
//        protected string name;
//        private double CGPA;

//        public Student1(int rollNumber, string name, double CGPA)
//        {
//            this.rollNumber = rollNumber;
//            this.name = name ?? "Unknown";  
//            this.CGPA = CGPA >= 0 ? CGPA : 0.0;  
//        }

//        public void DisplayStudentDetails()
//        {
//            Console.WriteLine("Roll Number: "+rollNumber);
//            Console.WriteLine("Name: "+name);
//            Console.WriteLine("CGPA: "+CGPA);
//        }

//        public void UpdateStudentDetails(string newName, double newCGPA)
//        {
//            SetName(newName ?? "Unknown");  
//            CGPA = newCGPA >= 0 ? newCGPA : CGPA;  
//        }

//        protected void SetName(string newName)
//        {
//            name = newName;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter Roll Number: ");
//            int rollNumber = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Enter CGPA: ");
//            double cgpa = Convert.ToDouble(Console.ReadLine());

//            Student1 student1 = new Student1(rollNumber, name, cgpa);

//            Console.WriteLine("\nStudent Details:");
//            student1.DisplayStudentDetails();

//            Console.Write("\nDo you want to update details? (yes/no): ");
//            string updateChoice = Console.ReadLine();

//            if (updateChoice.ToLower() == "yes")
//            {
//                Console.Write("Enter new Name: ");
//                string newName = Console.ReadLine();

//                Console.Write("Enter new CGPA: ");
//                double newCGPA = Convert.ToDouble(Console.ReadLine());

//                student1.UpdateStudentDetails(newName, newCGPA);
//            }

//            Console.WriteLine("\nUpdated Student Details:");
//            student1.DisplayStudentDetails();
//        }
//    }
