using System;

class SumNum
{
    static void Main()
    {
        double[] numbers = new double[10];
        ProcessData(numbers);
    }

    static void ProcessData(double[] numbers)
    {
        int index = 0;
        double total = 0.0;

        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number <= 0 || index == 10)
                break;

            numbers[index] = number;
            index++;
        }

        Console.WriteLine("\nEntered numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine("\nTotal sum of entered numbers: " + total);
    }
}
