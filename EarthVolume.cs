using System;

class EarthVolume
{
   
    static void ComputeVolume(double radiusKm)
    {
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
        double radiusMiles = radiusKm * 0.621371;
        double volumeMiles3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);
        Console.WriteLine("The volume of Earth in cubic kilometers is " +volumeKm3 +" and cubic miles is " +volumeMiles3);
    }
    static void Main(string[] args)
    {
        double radiusKm = 6378;
        ComputeVolume(radiusKm);
        Console.ReadLine();
    }
}
