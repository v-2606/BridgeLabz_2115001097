using System;
class Prog7{
   static void Main(String [] args)
   {
       Console.WriteLine("Enter the base:");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        
        Console.WriteLine("Enter the exponent:");
        double exponent = Convert.ToDouble(Console.ReadLine());

        
        double result = Math.Pow(baseNum, exponent);
        
		 Console.WriteLine("Answer is: " + result);
		Console.ReadLine();
	   
	   
	}
}