using System;

class TriangleArea{

static void calculate( double baseInInches,double heightInInches){
	
	    double areaInSquareInches = 0.5 * baseInInches * heightInInches;
        double baseInCm = baseInInches * 2.54;
        double heightInCm = heightInInches * 2.54;
        double areaInSquareCm = 0.5 * baseInCm * heightInCm;
	
	
	Console.WriteLine("square inches " +areaInSquareInches +" \n and area In Square Cm " +areaInSquareCm);
	Console.ReadLine();
  
}

static void Main(String[] args){
	
	 Console.Write("Enter the base of the triangle (in inches): ");
        double baseInInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle (in inches): ");
        double heightInInches = Convert.ToDouble(Console.ReadLine());
	
	 calculate(baseInInches,heightInInches);
	 
}
}