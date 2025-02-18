//using System;
//using System.Collections.Generic;

//public abstract class CourseType
//{
//    public string EvaluationMethod { get; set; }

//    public CourseType(string evaluationMethod)
//    {
//        EvaluationMethod = evaluationMethod;
//    }
//}

//public class ExamCourse : CourseType
//{
//    public ExamCourse() : base("Exam") { }
//}

//public class AssignmentCourse : CourseType
//{
//    public AssignmentCourse() : base("Assignment") { }
//}


//public class Course<T> where T : CourseType
//{
//    public string CourseName { get; set; }
//    public int Credits { get; set; }
//    public T CourseCategory { get; set; }

//    public Course(string courseName, int credits, T courseCategory)
//    {
//        CourseName = courseName;
//        Credits = credits;
//        CourseCategory = courseCategory;
//    }

//    public void DisplayCourse()
//    {
//        Console.WriteLine("Course: " + CourseName + ", Credits: " + Credits + ", Evaluation Method: " + CourseCategory.EvaluationMethod);
//    }
//}


//public class University
//{
//    private List<IUniversityCourse> courses = new List<IUniversityCourse>();

//    public void AddCourse(IUniversityCourse course)
//    {
//        courses.Add(course);
//    }

//    public void DisplayAllCourses()
//    {
//        Console.WriteLine("\nAvailable Courses:");
//        foreach (var course in courses)
//        {
//            course.DisplayCourse();
//        }
//    }
//}

//public interface IUniversityCourse
//{
//    void DisplayCourse();
//}
//public class ManagedCourse<T> : Course<T>, IUniversityCourse where T : CourseType
//{
//    public ManagedCourse(string courseName, int credits, T courseCategory) : base(courseName, credits, courseCategory) { }
//}


//class CourseManagement
//{
//    static void Main(string[] args)
//    {
//        var university = new University();

//        var csCourse = new ManagedCourse<ExamCourse>("Computer Science", 4, new ExamCourse());
//        var mathCourse = new ManagedCourse<AssignmentCourse>("Mathematics", 3, new AssignmentCourse());

//        university.AddCourse(csCourse);
//        university.AddCourse(mathCourse);

     
//        university.DisplayAllCourses();
//    }
//}
