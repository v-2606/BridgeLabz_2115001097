using System;

class Circle{
	
   private const double pie = 3.14;

     
	 private double Radius;

	 public  Circle(double Radius){
	this. Radius=Radius;
	  
	 }
	 public double CalculateArea(double Radius){
	   return pie*(Radius*Radius);
	 
	 }
	 
	 public double CalculateCircumfrance(double Radius){
	  return 2*Radius*pie;
	 }
	 
	 public void DetailDisplay(){
	 
	 Console.WriteLine("Area of the circle :" +CalculateArea(Radius));
	 Console.WriteLine("Circumfrance  of circle:" +CalculateCircumfrance(Radius));

	 }
	 
	 }
	 
	 class CircleCalculation {
		 
		 public static void Main(string[] args){
		Console.WriteLine("Enter radius:");
		double Radius= Convert.ToDouble(Console.ReadLine());
		
		
		
		Circle circle= new Circle(Radius);
		circle. DetailDisplay();
		
	 
	 }


}