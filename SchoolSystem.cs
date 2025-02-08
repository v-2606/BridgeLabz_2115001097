//using System;

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public string GetPersonDetails()
//    {
//        return $"Name: {Name}, Age: {Age}";
//    }

//    public void DisplayRole()
//    {
//        Console.WriteLine("Role: Person");
//    }
//}

//class Teacher
//{
//    public Person Person { get; set; }
//    public string Subject { get; set; }

//    public Teacher(Person person, string subject)
//    {
//        Person = person;
//        Subject = subject;
//    }

//    public void DisplayRole()
//    {
//        Console.WriteLine($"Role: Teacher, Subject: {Subject}");
//    }

//    public string GetDetails()
//    {
//        return $"{Person.GetPersonDetails()}, Subject: {Subject}";
//    }
//}

//class Student
//{
//    public Person Person { get; set; }
//    public string Grade { get; set; }

//    public Student(Person person, string grade)
//    {
//        Person = person;
//        Grade = grade;
//    }

//    public void DisplayRole()
//    {
//        Console.WriteLine($"Role: Student, Grade: {Grade}");
//    }

//    public string GetDetails()
//    {
//        return $"{Person.GetPersonDetails()}, Grade: {Grade}";
//    }
//}

//class Staff
//{
//    public Person Person { get; set; }
//    public string Department { get; set; }

//    public Staff(Person person, string department)
//    {
//        Person = person;
//        Department = department;
//    }

//    public void DisplayRole()
//    {
//        Console.WriteLine($"Role: Staff, Department: {Department}");
//    }

//    public string GetDetails()
//    {
//        return $"{Person.GetPersonDetails()}, Department: {Department}";
//    }
//}

//class SchoolSystem
//{
//    static void Main()
//    {
//        Console.Write("Enter Teacher's Name: ");
//        string teacherName = Console.ReadLine();
//        Console.Write("Enter Teacher's Age: ");
//        int teacherAge = int.Parse(Console.ReadLine());
//        Console.Write("Enter Teacher's Subject: ");
//        string teacherSubject = Console.ReadLine();
//        Teacher teacher = new Teacher(new Person(teacherName, teacherAge), teacherSubject);

//        Console.Write("\nEnter Student's Name: ");
//        string studentName = Console.ReadLine();
//        Console.Write("Enter Student's Age: ");
//        int studentAge = int.Parse(Console.ReadLine());
//        Console.Write("Enter Student's Grade: ");
//        string studentGrade = Console.ReadLine();
//        Student student = new Student(new Person(studentName, studentAge), studentGrade);

//        Console.Write("\nEnter Staff's Name: ");
//        string staffName = Console.ReadLine();
//        Console.Write("Enter Staff's Age: ");
//        int staffAge = int.Parse(Console.ReadLine());
//        Console.Write("Enter Staff's Department: ");
//        string staffDepartment = Console.ReadLine();
//        Staff staff = new Staff(new Person(staffName, staffAge), staffDepartment);

//        Console.WriteLine("\nDetails of School Members:\n");

//        teacher.DisplayRole();
//        Console.WriteLine(teacher.GetDetails());

//        student.DisplayRole();
//        Console.WriteLine(student.GetDetails());

//        staff.DisplayRole();
//        Console.WriteLine(staff.GetDetails());
//    }
//}
