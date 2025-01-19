using System;
class Prog8{
   static void Main(String [] args)
   {
        Console.WriteLine("Enter the num1:");
        double Num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.WriteLine("Enter the num2:");
        double Num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the num3:");
        double Num3 = Convert.ToDouble(Console.ReadLine());
        
        double avg =(Num1+Num2+Num3)/3;
        
		 Console.WriteLine("Answer is: " + avg);
		Console.ReadLine();
	   
	   
	}
}