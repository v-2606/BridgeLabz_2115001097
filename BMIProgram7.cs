using System;

class BMIProgram7
{
    static void BMI2()
    {
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        double[,] personData = new double[numPersons, 3];
        string[] weightStatus = new string[numPersons];

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("\nPerson" + (i + 1));

            double height;
            do
            {
                Console.Write("Enter height (in meters, positive value): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Height must be a positive value. Please enter again.");
                }
            } while (height <= 0);
            personData[i, 0] = height;

            double weight;
            do
            {
                Console.Write("Enter weight (in kg, positive value): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Weight must be a positive value. Please enter again.");
                }
            } while (weight <= 0);
            personData[i, 1] = weight;

            personData[i, 2] = weight / (height * height);

            if (personData[i, 2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i, 2] >= 18.5 && personData[i, 2] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (personData[i, 2] >= 25 && personData[i, 2] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obesity";
        }

        Console.WriteLine("\nSummary of each person:");
        

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("{0,6} | {1,12:F2} | {2,11:F2} | {3,7:F2} | {4,12}",
                              i + 1, personData[i, 0], personData[i, 1], personData[i, 2], weightStatus[i]);
        }
    }

    static void Main(string[] args)
    {
        BMI2();
    }
}
