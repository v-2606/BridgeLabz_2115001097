
//using System;

//class QuickSort
//{
//    public static void QuickSortScores(int[] scores, int left, int right)
//    {
//        if (left < right)
//        {
//            int pivotIndex = Partition(scores, left, right);
//            QuickSortScores(scores, left, pivotIndex - 1);
//            QuickSortScores(scores, pivotIndex + 1, right);
//        }
//    }

//    private static int Partition(int[] scores, int left, int right)
//    {
//        int pivot = scores[right];
//        int i = left - 1;

//        for (int j = left; j < right; j++)
//        {
//            if (scores[j] < pivot)
//            {
//                i++;
//                Swap(scores, i, j);
//            }
//        }

//        Swap(scores, i + 1, right);
//        return i + 1;
//    }

//    private static void Swap(int[] arr, int i, int j)
//    {
//        int temp = arr[i];
//        arr[i] = arr[j];
//        arr[j] = temp;
//    }

//    public static void Main(string[] args)
//    {
//        Console.Write("Enter number of students: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] examScores = new int[n];

//        Console.WriteLine("Enter exam scores:");
//        for (int i = 0; i < n; i++)
//        {
//            examScores[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Original Scores: " + string.Join(", ", examScores));
//        QuickSortScores(examScores, 0, examScores.Length - 1);
//        Console.WriteLine("Sorted Scores: " + string.Join(", ", examScores));
//    }
//}





