//using System;

//class BinarySearch1
//{
//    public static int FindRotationPoint(int[] arr)
//    {
//        int left = 0, right = arr.Length - 1;

//        while (left < right)
//        {
//            int mid = left + (right - left) / 2;

//            if (arr[mid] > arr[right])
//            {
//                left = mid + 1;
//            }
//            else
//            {
//                right = mid;
//            }
//        }

//        return left;
//    }

//    static void Main(string[]args)
//    {
//        Console.Write("Enter the number of elements: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        Console.WriteLine("elements of the rotated sorted array:");

//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int rotationPoint = FindRotationPoint(arr);
//        Console.WriteLine("The rotation point (index of the smallest element) is: " + rotationPoint);
//    }
//}
