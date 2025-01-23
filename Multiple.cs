using System;

class Multiple
{
    static void PrintMultiples(int number)
    {
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        PrintMultiples(number);
    }
}
