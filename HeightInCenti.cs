using System;

class HeightInCenti{
static void ConvertHeight(double centi){
	double inch = centi/2.54;
	double feet=inch/12;
	Console.WriteLine("your height in cm is "+centi +"while in feet is "+feet+"and inches is "+inch);
	Console.ReadLine();
}

static void Main(String[] args)
{
	 
	Console.WriteLine("Enter height in cm :");
	double Height = Convert.ToDouble(Console.ReadLine());

	ConvertHeight(Height);
		Console.ReadLine();
}
}