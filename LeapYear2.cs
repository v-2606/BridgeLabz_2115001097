using System;

class LeapYear2
{
    static void CheckLeapYear(int year)
    {
        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }

    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        CheckLeapYear(year);
    }
}
