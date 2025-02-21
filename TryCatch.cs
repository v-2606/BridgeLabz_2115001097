
//using System;

//class TryCatch
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            Console.Write("Enter the size of the array: ");
//            int size = int.Parse(Console.ReadLine());

//            int[] arr = new int[size];

//            Console.WriteLine("Enter array elements:");
//            for (int i = 0; i < size; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            Console.Write("Enter the index to access: ");
//            int index = int.Parse(Console.ReadLine());

//            try
//            {
//                int value = arr[index];

//                Console.Write("Enter a divisor: ");
//                int divisor = int.Parse(Console.ReadLine());

//                try
//                {
//                    int result = value / divisor;
//                    Console.WriteLine($"Result: {value} / {divisor} = {result}");
//                }
//                catch (DivideByZeroException)
//                {
//                    Console.WriteLine("Cannot divide by zero!");
//                }
//            }
//            catch (IndexOutOfRangeException)
//            {
//                Console.WriteLine("Invalid array index!");
//            }
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Error: Please enter valid numeric values.");
//        }
//    }
//}
