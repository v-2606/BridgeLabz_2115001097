using System;

class BMI
{
    static void CalculateBMI(double weight, double height)
    {
        height = height / 100; // Convert height from cm to meters
        double bmi = weight / (height * height);

        Console.WriteLine("Your BMI is: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("You are Underweight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a Normal weight.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are Overweight.");
        }
        else
        {
            Console.WriteLine("You are Obese.");
        }
    }

    static void Main()
    {
        Console.Write("Enter your weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());

        CalculateBMI(weight, height);
    }
}
