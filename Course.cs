//using System;

//class Course
//{
//    private string courseName;
//    private string duration;
//    private double fee;
//    private static/*(class vari becoz of static)*/ string instituteName = "Unknown Institute"; 

//    public Course(string courseName, string duration, double fee)
//    {
//        this.courseName = courseName;
//        this.duration = duration;
//        this.fee = fee;
//    }

//    public void DisplayCourseDetails()
//    {
//        Console.WriteLine("Course Name: " + courseName);
//        Console.WriteLine("Duration: " + duration);
//        Console.WriteLine("Fee: $" + fee);
//        Console.WriteLine("Institute: " + instituteName);
//    }

//    public static void UpdateInstituteName(string newInstituteName)
//    {
//        instituteName = newInstituteName;
//        Console.WriteLine("Institute name updated to: " + instituteName);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
        
//        Console.Write("Enter the number of courses: ");
//        int numCourses = Convert.ToInt32(Console.ReadLine());

//        Course[] courses = new Course[numCourses];

//        for (int i = 0; i < numCourses; i++)
//        {
//            Console.WriteLine("\nEnter details for Course " + (i + 1) + ":");

//            Console.Write("Enter course name: ");
//            string courseName = Console.ReadLine();

//            Console.Write("Enter duration of the course: ");
//            string duration = Console.ReadLine();

//            Console.Write("Enter fee for the course: ");
//            double fee = Convert.ToDouble(Console.ReadLine());

//            courses[i] = new Course(courseName, duration, fee);
//        }

        
//        Console.WriteLine("\n Details ");
//        foreach (var course in courses)
//        {
//            course.DisplayCourseDetails();
//            Console.WriteLine();
//        }

        
//        Console.Write("\nEnter new institute : ");
//        string newInstituteName = Console.ReadLine();
//        Course.UpdateInstituteName(newInstituteName);

       
//        Console.WriteLine("\nDetails Update");
//        foreach (var course in courses)
//        {
//            course.DisplayCourseDetails();
//            Console.WriteLine();
//        }
//    }
//}

