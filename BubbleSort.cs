
//using System;

//class BubbleSort
//{
   
//    static void Bubble(int[] marks)
//    {
//        int n = marks.Length;

//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
                
//                if (marks[j] > marks[j + 1])
//                {
//                    int temp = marks[j];
//                    marks[j] = marks[j + 1];
//                    marks[j + 1] = temp;
//                }
//            }
//        }
//    }

    
//    static void PrintArray(int[] marks)
//    {
//        foreach (int mark in marks)
//        {
//            Console.Write(mark + " ");
//        }
//        Console.WriteLine();
//    }

//    static void Main(string[] args)
//    {
        
//        Console.Write("Enter number of students: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] studentMarks = new int[n];
//        Console.WriteLine("Enter marks of students:");

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Student {i + 1}: ");
//            studentMarks[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nOriginal Marks:");
//        PrintArray(studentMarks);

       
//        Bubble(studentMarks);

//        Console.WriteLine("Sorted Marks:");
//        PrintArray(studentMarks);
//    }
//}
