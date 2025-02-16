//using System;

//class LinearSaerch1
//{
   
//    public static int FindFirstNegative(int[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] < 0)
//            {
//                return arr[i]; 
//            }
//        }
//        return 0; 
//    }

//    static void Main(string[]args)
//    {
//        Console.Write(" number of elements in the array: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        Console.WriteLine("Enter elements :");

//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

       
//        int firstNegative = FindFirstNegative(arr);

//        if (firstNegative != 0)
//        {
//            Console.WriteLine("The first negative number is: " + firstNegative);
//        }
//        else
//        {
//            Console.WriteLine("No negative found.");
//        }
//    }
//}
