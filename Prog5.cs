using System;
class Prog5{
   static void Main(String [] args)
   {
       Console.WriteLine("input Principal");
	   int Principal = Convert.ToInt32(Console.ReadLine());
	   
	   Console.WriteLine("input Rate");
	   int Rate =Convert.ToInt32(Console.ReadLine());
	   
	    Console.WriteLine("input Time");
	    int Time =Convert.ToInt32(Console.ReadLine());
	   
	  double Simple_Interest = (Principal * Rate * Time) / 100.0;
	   Console.WriteLine("Simple Interest is:" +Simple_Interest);
	   Console.ReadLine();
	   
	   
	}
}