using System;

class Convert{
	public double MilesToKm(double km){
	return (km*0.621371);
	
	}
}
class ConvertToMiles{
	static void Main(String[] args){
	 double km= 10.8;
	 
	 Convert InMiles= new Convert();
	 double Conversion=InMiles.MilesToKm(km);
	 
	 Console.WriteLine("Converted into miles:" +Conversion);
	 Console.ReadLine();
	
	}
}