using System;

class SwapNumbers
{
    static void SwapValues(ref int number1, ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        SwapValues(ref number1, ref number2);

        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
