using System;
class Prog6{
   static void Main(String [] args)
   {
       Console.WriteLine("input length");
	   int length = Convert.ToInt32(Console.ReadLine());
	   
	   Console.WriteLine("input width");
	   int width =Convert.ToInt32(Console.ReadLine());
	   
	   
	  int perimeter = 2 * (length + width);
	   Console.WriteLine("perimeter is:" +perimeter);
	   Console.ReadLine();
	   
	   
	}
}