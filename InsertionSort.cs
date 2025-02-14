//using System;

//class InsertionSort
//{
    
//    static void Insertion(int[] empIds)
//    {
//        int n = empIds.Length;

//        for (int i = 1; i < n; i++)
//        {
//            int key = empIds[i];
//            int j = i - 1;

       
//            while (j >= 0 && empIds[j] > key)
//            {
//                empIds[j + 1] = empIds[j];
//                j--;
//            }

//            empIds[j + 1] = key; 
//        }
//    }

   
//    static void PrintArray(int[] empIds)
//    {
//        foreach (int id in empIds)
//        {
//            Console.Write(id + " ");
//        }
//        Console.WriteLine();
//    }

//    static void Main(string[] args)
//    {
        
//        Console.Write("Enter number of employees: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] empIds = new int[n];

//        Console.WriteLine("Enter Employee IDs:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Employee " + (i + 1) + " ID: "); 
//            empIds[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nOriginal Employee IDs:");
//        PrintArray(empIds);

//        Insertion(empIds);

//        Console.WriteLine("Sorted Employee IDs:");
//        PrintArray(empIds);
//    }
//}

  