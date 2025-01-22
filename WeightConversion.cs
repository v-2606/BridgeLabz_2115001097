using System;

class WeightConversion
{
    static void ConvertWeight(double weightInPounds)
    {
        double weightInKg = weightInPounds * 2.2;
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKg);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        ConvertWeight(weightInPounds);
    }
}
