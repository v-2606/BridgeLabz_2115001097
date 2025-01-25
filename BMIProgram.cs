using System;

class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        double[] weight = new double[numberOfPersons];
        double[] height = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1) + ":");
            Console.Write("Enter weight (in kg): ");
            weight[i] = double.Parse(Console.ReadLine());
            Console.Write("Enter height (in meters): ");
            height[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi[i] >= 25 && bmi[i] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        Console.WriteLine("\nSummary of BMI and Weight Status:");
        
        

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine((i + 1) + "\t" + height[i] + "\t" + weightStatus[i]);
        }
    }
}
