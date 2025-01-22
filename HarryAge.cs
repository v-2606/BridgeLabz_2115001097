using System;


	class AgeCalculator{
	
		public int CalculateAge(int birthYear, int currentYear){
		 
		 return currentYear-birthYear;
		
		}
		
	
	
	}
	 class HarryAge{
	 
		static void Main(string[] args){
		
		 int birthYear=2000;
		 int currentYear=2024;
		
		AgeCalculator agecalculator=new AgeCalculator();
		
		int harryAge = agecalculator.CalculateAge(birthYear,currentYear);
		
		Console.WriteLine("Harry Age in 2024 is :" +harryAge);
		Console.ReadLine();
		
		
		}
	 
	 
	 
	 }



