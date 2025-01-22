using System;
class KiloToMiles{
   static void Main(String [] args)
   {
        Console.WriteLine(" distance in kilometer:");
        double kilometer = Convert.ToDouble(Console.ReadLine());

        
        double miles= kilometer * 0.621371;
        
		 Console.WriteLine("Answer is: " + miles);
		Console.ReadLine();
	   
	   
	}
}