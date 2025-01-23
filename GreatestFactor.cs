using System;
class GreatestFactor
{
    static void PrintGreatestFactor(int number)
    {
        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine("The greatest factor of " + number + " besides itself is: " + greatestFactor);
    }

    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        PrintGreatestFactor(number);
    }
}
