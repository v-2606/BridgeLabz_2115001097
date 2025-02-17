//using System;
//using System.Diagnostics;

//class SearchComparison
//{
//    static void Main(string[] args)
//    {
//        int[] dataset = GenerateDataset(1000000);
//        int target = 999999;

//        MeasureTime("Linear Search", () => LinearSearch(dataset, target));

//        Array.Sort(dataset);
//        MeasureTime("Binary Search", () => BinarySearch(dataset, target));
//    }

//    static int LinearSearch(int[] arr, int target)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] == target)
//                return i;
//        }
//        return -1;
//    }

//    static int BinarySearch(int[] arr, int target)
//    {
//        int left = 0, right = arr.Length - 1;
//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;
//            if (arr[mid] == target)
//                return mid;
//            else if (arr[mid] < target)
//                left = mid + 1;
//            else
//                right = mid - 1;
//        }
//        return -1;
//    }

//    static void MeasureTime(string method, Action searchMethod)
//    {
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        searchMethod();
//        stopwatch.Stop();
//        Console.WriteLine($"{method} Time: {stopwatch.ElapsedMilliseconds} ms");
//    }

//    static int[] GenerateDataset(int size)
//    {
//        int[] arr = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = i;
//        }
//        return arr;
//    }
//}

