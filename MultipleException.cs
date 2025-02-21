//using System;

//class MultipleException
//{
    
//    static void GetValueAtIndex(int[] arr, int index)
//    {
//        try
//        {
          
//            if (arr == null)
//            {
//                throw new NullReferenceException();
//            }

          
//            Console.WriteLine($"Value at index {index}: {arr[index]}");
//        }
//        catch (IndexOutOfRangeException)
//        {
//            Console.WriteLine("Error: Invalid index!");
//        }
//        catch (NullReferenceException)
//        {
//            Console.WriteLine("Error: Array is not initialized!");
//        }
//    }

//    static void Main(string[] args)
//    {
//        try
//        {
          
//            Console.Write("Enter the size of the array: ");
//            int size = int.Parse(Console.ReadLine());

          
//            int[] arr = size > 0 ? new int[size] : null;

        
//            if (arr != null)
//            {
//                Console.WriteLine("Enter array elements:");
//                for (int i = 0; i < size; i++)
//                {
//                    Console.Write($"Element {i}: ");
//                    arr[i] = int.Parse(Console.ReadLine());
//                }
//            }

//              Console.Write("Enter the index to retrieve value: ");
//            int index = int.Parse(Console.ReadLine());

         
//            GetValueAtIndex(arr, index);
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Error: Please enter valid numeric values.");
//        }
//    }
//}

