//using System;

//class StudentRecord
//{
//    public int RollNo;
//    public string Name;
//    public int Age;
//    public string Grade;
//    public StudentRecord Next;

//    public StudentRecord(int rollNo, string name, int age, string grade)
//    {
//        RollNo = rollNo;
//        Name = name;
//        Age = age;
//        Grade = grade;
//        Next = null;
//    }
//}

//class Student
//{
//    private StudentRecord head;

   
//    public void InsertAtFirst(int rollNo, string name, int age, string grade)
//    {
//        StudentRecord student = new StudentRecord(rollNo, name, age, grade);
//        student.Next = head;
//        head = student;
//    }

//    public void InsertAtPosition(int pos, int rollNo, string name, int age, string grade)
//    {
//        if (pos <= 0)
//        {
//            Console.WriteLine("Invalid Position");
//            return;
//        }

//        if (pos == 1)
//        {
//            InsertAtFirst(rollNo, name, age, grade);
//            return;
//        }

//        StudentRecord newStudent = new StudentRecord(rollNo, name, age, grade);
//        StudentRecord temp = head;
//        int count = 1;

//        while (temp != null && count < pos - 1)
//        {
//            temp = temp.Next;
//            count++;
//        }

//        if (temp == null)
//        {
//            Console.WriteLine("Invalid Position");
//            return;
//        }

//        newStudent.Next = temp.Next;
//        temp.Next = newStudent;
//    }

 
//    public void InsertAtLast(int rollNo, string name, int age, string grade)
//    {
//        StudentRecord student = new StudentRecord(rollNo, name, age, grade);

//        if (head == null)
//        {
//            head = student;
//            return;
//        }

//        StudentRecord temp = head;
//        while (temp.Next != null)
//        {
//            temp = temp.Next;
//        }
//        temp.Next = student;
//    }

   
//    public void Delete(int rollNo)
//    {
//        if (head == null)
//        {
//            Console.WriteLine("List is empty");
//            return;
//        }

//        if (head.RollNo == rollNo)
//        {
//            head = head.Next;
//            Console.WriteLine("Student with Roll No " + rollNo + " deleted.");
//            return;
//        }

//        StudentRecord temp = head;
//        while (temp.Next != null && temp.Next.RollNo != rollNo)
//        {
//            temp = temp.Next;
//        }

//        if (temp.Next == null)
//        {
//            Console.WriteLine("Student with Roll No " + rollNo + " not found.");
//            return;
//        }

//        temp.Next = temp.Next.Next;
//        Console.WriteLine("Student with Roll No " + rollNo + " deleted.");
//    }

   
//    public void Search(int rollNo)
//    {
//        StudentRecord temp = head;

//        while (temp != null)
//        {
//            if (temp.RollNo == rollNo)
//            {
//                Console.WriteLine("Roll No: " + temp.RollNo + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
//                return;
//            }
//            temp = temp.Next;
//        }
//        Console.WriteLine("Student with Roll No " + rollNo + " not found.");
//    }

  
//    public void UpdateGrade(int rollNo, string newGrade)
//    {
//        StudentRecord temp = head;
//        while (temp != null)
//        {
//            if (temp.RollNo == rollNo)
//            {
//                temp.Grade = newGrade;
//                Console.WriteLine("Grade updated for Roll No " + rollNo + " to " + newGrade);
//                return;
//            }
//            temp = temp.Next;
//        }
//        Console.WriteLine("Student with Roll No " + rollNo + " not found.");
//    }

    
//    public void Display()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("No student records to show.");
//            return;
//        }

//        StudentRecord temp = head;
//        while (temp != null)
//        {
//            Console.WriteLine("Roll No: " + temp.RollNo + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
//            temp = temp.Next;
//        }
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Student students = new Student();

//        while (true)
//        {
//            Console.WriteLine("\n1. Add Student\n2. Delete Student\n3. Search Student\n4. Update Grade\n5. Display All\n6. Exit");
//            Console.Write("Enter your choice: ");

//            if (!int.TryParse(Console.ReadLine(), out int choice))
//            {
//                Console.WriteLine("Invalid input. Please enter a number.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    Console.Write("Enter Roll No: ");
//                    int roll = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Name: ");
//                    string name = Console.ReadLine();
//                    Console.Write("Enter Age: ");
//                    int age = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Grade: ");
//                    string grade = Console.ReadLine();
//                    students.InsertAtLast(roll, name, age, grade);
//                    break;

//                case 2:
//                    Console.Write("Enter Roll No to delete: ");
//                    int delRoll = int.Parse(Console.ReadLine());
//                    students.Delete(delRoll);
//                    break;

//                case 3:
//                    Console.Write("Enter Roll No to search: ");
//                    int searchRoll = int.Parse(Console.ReadLine());
//                    students.Search(searchRoll);
//                    break;

//                case 4:
//                    Console.Write("Enter Roll No to update grade: ");
//                    int updateRoll = int.Parse(Console.ReadLine());
//                    Console.Write("Enter new Grade: ");
//                    string newGrade = Console.ReadLine();
//                    students.UpdateGrade(updateRoll, newGrade);
//                    break;

//                case 5:
//                    students.Display();
//                    break;

//                case 6:
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//    }
//}
