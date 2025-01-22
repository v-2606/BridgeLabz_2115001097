using System;

class YardMiles{
  static void YardTOMiles(double distanceInFeet ){
    	double feetToYards = 1.0 / 3.0;  
        double feetToMiles = 1.0 / (3.0 * 1760.0);  

        double distanceInYards = distanceInFeet * feetToYards;
        double distanceInMiles = distanceInFeet * feetToMiles; 
		
		Console.WriteLine("distance in yards "+distanceInYards +"\n distance in miles" +distanceInMiles);
  }
  static void Main(String[] args)
    {
        Console.Write("Enter the distance (in feet): ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
		
	YardTOMiles(distanceInFeet);
}
}