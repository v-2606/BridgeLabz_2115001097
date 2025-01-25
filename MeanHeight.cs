using System;

class MeanHeight
{
    static void Main()
    {
        double[] heights = new double[11];

        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter the height of player " + (i + 1) + ": ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        double meanHeight = CalculateMeanHeight(heights);
        Console.WriteLine("\nThe mean height of the football team is: " + meanHeight.ToString("F2"));
    }

    static double CalculateMeanHeight(double[] heights)
    {
        double sum = 0.0;

        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }

        return sum / heights.Length;
    }
}
