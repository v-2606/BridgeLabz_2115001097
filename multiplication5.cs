using System;
class  multiplication
{
    static void Main()
    {
        Console.Write("Enter a number between 6 and 9  ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 6 && number <= 9)
        {
            DisplayMultiplicationTable(number);
        }
        else
        {
            Console.WriteLine("Please enter a number between 6 and 9.");
        }
    }

    static void DisplayMultiplicationTable(int number)
    {
        int[] multiplicationResult = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            multiplicationResult[i - 1] = number * i;
        }

        Console.WriteLine("\nMultiplication table for " + number + ":");
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + multiplicationResult[i]);
        }
    }
}
