using System;

class MatrixDisplay
{
    static void Main(String[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int[] array = new int[rows * columns];

        Display(matrix, array, rows, columns);
    }

    static void Display(int[,] matrix, int[] array, int rows, int columns)
    {
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Enter element for row " + (i + 1) + ", column " + (j + 1) + ": ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("\nElements of the 1D array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Position " + (i + 1) + ": " + array[i]);
        }
    }
}
