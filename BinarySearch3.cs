//using System;

//class BinarySearch3
//{
//    public static bool SearchMatrix(int[,] matrix, int target)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        int left = 0, right = rows * cols - 1;

//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;
//            int midValue = matrix[mid / cols, mid % cols];

//            if (midValue == target)
//            {
//                return true;
//            }

//            if (midValue < target)
//            {
//                left = mid + 1;
//            }
//            else
//            {
//                right = mid - 1;
//            }
//        }

//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter the number of rows: ");
//        int rows = int.Parse(Console.ReadLine());

//        Console.Write("Enter the number of columns: ");
//        int cols = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[rows, cols];

//        Console.WriteLine("Enter the elements of the matrix:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.Write("Enter the target value to search: ");
//        int target = int.Parse(Console.ReadLine());

//        bool found = SearchMatrix(matrix, target);

//        if (found)
//        {
//            Console.WriteLine("Target value found .");
//        }
//        else
//        {
//            Console.WriteLine("Target value not found .");
//        }
//    }
//}
