using System;

class Multiplication
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nMultiplication table for " + number + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
