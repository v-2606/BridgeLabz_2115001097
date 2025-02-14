//using System;
//class SelectionSort
//{
//    public static void SelectionSortScores(int[] scores)
//    {
//        int n = scores.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            int minIndex = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (scores[j] < scores[minIndex])
//                {
//                    minIndex = j;
//                }
//            }
//            Swap(scores, i, minIndex);
//        }
//    }

//    private static void Swap(int[] arr, int i, int j)
//    {
//        int temp = arr[i];
//        arr[i] = arr[j];
//        arr[j] = temp;
//    }

//    public static void Main(string[] args)
//    {
//        Console.Write("Enter no. students: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] examScores = new int[n];

//        Console.WriteLine("Enter exam scores:");
//        for (int i = 0; i < n; i++)
//        {
//            examScores[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Original Scores: " + string.Join(", ", examScores));
//        SelectionSortScores(examScores);
//        Console.WriteLine("Sorted Scores: " + string.Join(", ", examScores));
//    }
//}



