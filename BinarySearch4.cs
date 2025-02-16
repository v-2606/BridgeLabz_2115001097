using System;

class BinarySearch4
{
    public static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int first = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                first = mid;
                right = mid - 1;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return first;
    }

    public static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int last = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                last = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return last;
    }

    static void Main(string[]args)
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter sorted array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter target: ");
        int target = int.Parse(Console.ReadLine());

        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);

        if (first == -1)
        {
            Console.WriteLine("Target not found.");
        }
        else
        {
            Console.WriteLine("First index: " + first);
            Console.WriteLine("Last index: " + last);
        }
    }
}
