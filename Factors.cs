using System;
class Factors
{
    static int[] FindFactors(int number)
    {
        int[] tempFactors = new int[number];
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                tempFactors[count++] = i;
            }
        }

        int[] factors = new int[count];
        for (int i = 0; i < count; i++)
        {
            factors[i] = tempFactors[i];
        }

        return factors;
    }

    static void Main()
    {
        Console.Write("Enter a number to find its factors: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive number.");
            return;
        }

        int[] factors = FindFactors(number);

        Console.WriteLine("\nFactors of " + number + ": " + string.Join(" ", factors));
    }
}
