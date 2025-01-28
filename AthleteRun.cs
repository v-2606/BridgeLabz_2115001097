using System;

class AthleteRun
{
    static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double distanceInMeters = 5000;
        double rounds = distanceInMeters / perimeter;
        return rounds;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first side of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double TotalRounds=CalculateRounds(side1, side2, side3);
		Console.WriteLine("The total number of rounds the athlete will run is " + Math.Ceiling(TotalRounds));
    }
}
