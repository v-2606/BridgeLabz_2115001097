using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        AnalyzeNumbers(numbers);
    }

    static void AnalyzeNumbers(int[] numbers)
    {
        Console.WriteLine("\nAnalysis of the entered numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                Console.WriteLine("The number is positive.");
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        Console.WriteLine("\nComparison of the first and last numbers:");
        if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (numbers[0] < numbers[4])
        {
            Console.WriteLine("The first number is less than the last number.");
        }
        else
        {
            Console.WriteLine("The first and last numbers are equal.");
        }
    }
}
