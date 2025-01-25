using System;

class FrequencyDisplay
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] frequency = new int[10];

        Frequency(number, frequency);
    }

    static void Frequency(int number, int[] frequency)
    {
        while (number > 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        Console.WriteLine("Frequency of each digit:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + frequency[i]);
            }
        }
    }
}
