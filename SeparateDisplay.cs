using System;

class SeparateDisplay
{
    static void DisplayOddEvenNumbers(int number)
    {
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];

        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex++] = i;
            }
            else
            {
                oddNumbers[oddIndex++] = i;
            }
        }

        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }

        Console.WriteLine("\n\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
    }

    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number greater than 0.");
             Environment.Exit(0);
        }

       DisplayOddEvenNumbers(number);
    }
}
