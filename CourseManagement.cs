//using System;

//class Course
//{
//    public string CourseName { get; set; }
//    public int Duration { get; set; }

//    public Course(string courseName, int duration)
//    {
//        CourseName = courseName;
//        Duration = duration;
//    }

//    public string GetCourseDetails()
//    {
//        return $"Course: {CourseName}, Duration: {Duration} hours";
//    }
//}

//interface IOnline
//{
//    string GetPlatform();
//    bool IsRecorded();
//}

//class OnlineCourse : IOnline
//{
//    public Course Course { get; set; }
//    public string Platform { get; set; }
//    public bool Recorded { get; set; }

//    public OnlineCourse(Course course, string platform, bool recorded)
//    {
//        Course = course;
//        Platform = platform;
//        Recorded = recorded;
//    }

//    public string GetCourseDetails()
//    {
//        return $"{Course.GetCourseDetails()}, Platform: {Platform}, Recorded: {(Recorded ? "Yes" : "No")}";
//    }

//    public string GetPlatform() => Platform;
//    public bool IsRecorded() => Recorded;
//}

//class PaidOnlineCourse
//{
//    public OnlineCourse OnlineCourse { get; set; }
//    public double Fee { get; set; }
//    public double Discount { get; set; }

//    public PaidOnlineCourse(OnlineCourse onlineCourse, double fee, double discount)
//    {
//        OnlineCourse = onlineCourse;
//        Fee = fee;
//        Discount = discount;
//    }

//    public double GetFinalFee()
//    {
//        return Fee - (Fee * Discount / 100);
//    }

//    public string GetCourseDetails()
//    {
//        return $"{OnlineCourse.GetCourseDetails()}, Fee: ${Fee}, Discount: {Discount}%, Final Fee: ${GetFinalFee()}";
//    }
//}

//class CourseManagement
//{
//    static void Main()
//    {
//        Console.Write("Enter Course Name: ");
//        string courseName = Console.ReadLine();

//        Console.Write("Enter Course Duration (in hours): ");
//        int duration = int.Parse(Console.ReadLine());

//        Console.Write("Enter Platform Name: ");
//        string platform = Console.ReadLine();

//        Console.Write("Is the Course Recorded? (yes/no): ");
//        bool recorded = Console.ReadLine().Trim().ToLower() == "yes";

//        Console.Write("Enter Course Fee: ");
//        double fee = double.Parse(Console.ReadLine());

//        Console.Write("Enter Discount Percentage: ");
//        double discount = double.Parse(Console.ReadLine());

//        Course course = new Course(courseName, duration);
//        OnlineCourse onlineCourse = new OnlineCourse(course, platform, recorded);
//        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse(onlineCourse, fee, discount);

//        Console.WriteLine("\nCourse Details:\n");
//        Console.WriteLine(course.GetCourseDetails());
//        Console.WriteLine(onlineCourse.GetCourseDetails());
//        Console.WriteLine(paidOnlineCourse.GetCourseDetails());
//    }
//}
