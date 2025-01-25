using System;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int tempNumber = number;
        int digitCount = 0;

        while (tempNumber != 0)
        {
            tempNumber = tempNumber / 10;
            digitCount++;
        }

        int[] digits = new int[digitCount];
        tempNumber = number;

        for (int i = 0; i < digitCount; i++)
        {
            digits[i] = tempNumber % 10;
            tempNumber = tempNumber / 10;
        }

        Console.WriteLine("Reversed number:");

        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
