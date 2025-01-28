using System;
class Wind_Chill{
 
static double CalculateWindChill(double temperature, double windSpeed)
    {
        double windChill = 35.74 + 0.6215 *temperature + (0.4275*temperature - 35.75) * windSpeed *0.16 ; 
       
        return windChill;
    }
   
  

	static void Main(string [] args)
	{
	  
        Console.Write("Enter the temperature: ");
        double Temperature = int.Parse(Console.ReadLine());

        Console.Write("Enter the windSpeed : ");
        double WindSpeed = int.Parse(Console.ReadLine());


        double result = CalculateWindChill(Temperature, WindSpeed);
		Console.WriteLine("windChill is " +result);
		
		
		Console.ReadLine();
	 }
}