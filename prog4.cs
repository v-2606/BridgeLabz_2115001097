using System;
class Prog4{
   static void Main(String [] args)
   {
       Console.WriteLine("input Radius");
	   int Radius =Convert.ToInt32(Console.ReadLine());
	   
	   Console.WriteLine("input height");
	   int height =Convert.ToInt32(Console.ReadLine());
	   
	  double Volume = Math.PI * Math.Pow(Radius, 2)*height;
	   Console.WriteLine("Area:" +Volume);
	   Console.ReadLine();
	   
	   
	}
}