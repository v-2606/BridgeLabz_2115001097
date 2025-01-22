using System;

class TripDetails
{
    static void CalculateTripDetails(string name, string fromCity, string viaCity, string toCity, double fromToVia, double viaToFinalCity, double timeTaken)
    {
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip are: " + name + ", from " + fromCity + " via " + viaCity + " to " + toCity + ". Total distance: " + totalDistance + " miles. Average speed: " + averageSpeed + " miles per hour.");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from {0} to {1} (miles): ", fromCity, viaCity);
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from {0} to {1} (miles): ", viaCity, toCity);
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time taken for the journey (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        CalculateTripDetails(name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken);
    }
}
