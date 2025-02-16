//using System;

//class LinearBinary
//{
//    public static int FindFirstMissingPositive(int[] arr)
//    {
//        int n = arr.Length;

//        for (int i = 0; i < n; i++)
//        {
//            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
//            {
//                int temp = arr[arr[i] - 1];
//                arr[arr[i] - 1] = arr[i];
//                arr[i] = temp;
//            }
//        }

//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] != i + 1)
//            {
//                return i + 1;
//            }
//        }

//        return n + 1;
//    }

//    public static int BinarySearch(int[] arr, int target)
//    {
//        int left = 0, right = arr.Length - 1;

//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;

//            if (arr[mid] == target)
//            {
//                return mid;
//            }

//            if (arr[mid] < target)
//            {
//                left = mid + 1;
//            }
//            else
//            {
//                right = mid - 1;
//            }
//        }

//        return -1;
//    }

//    static void Main(string[] args)
//    {
//        Console.Write(" number of elements in the array: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        Console.WriteLine("elements of the array:");

//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int missingPositive = FindFirstMissingPositive(arr);
//        Console.WriteLine(" first missing positive integer : " + missingPositive);

//        Array.Sort(arr);

//        Console.Write(" target number to search: ");
//        int target = int.Parse(Console.ReadLine());

//        int targetIndex = BinarySearch(arr, target);

//        if (targetIndex != -1)
//        {
//            Console.WriteLine($"The target number {target} is found at index: {targetIndex}");
//        }
//        else
//        {
//            Console.WriteLine("not found ");
//        }
//    }
//}
