using System;

class EvenOdd
{
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsEven(i))
                {
                    Console.WriteLine(i + " is even.");
                }
                else if (IsOdd(i))
                {
                    Console.WriteLine(i + " is odd.");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
        }
    }
}
