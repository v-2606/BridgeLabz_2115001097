﻿//using System;

//class BinarySearch2
//{
//    public static int FindPeakElement(int[] arr)
//    {
//        int left = 0, right = arr.Length - 1;

//        while (left < right)
//        {
//            int mid = left + (right - left) / 2;

//            if (arr[mid] > arr[mid + 1])
//            {
//                right = mid;
//            }
//            else
//            {
//                left = mid + 1;
//            }
//        }

//        return left;
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter the number of elements in the array: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        Console.WriteLine("Enter the elements of the array:");

//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int peakIndex = FindPeakElement(arr);
//        Console.WriteLine("The peak element is at index: " + peakIndex);
//    }
//}
