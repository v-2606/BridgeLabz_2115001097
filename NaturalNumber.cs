using System;

class NaturalNumber{
		static void CheackNaturalNumber(int num1){
		if(num1>=0){
		int SumNaturalNumber=num1 *(num1 +1) / 2; 
		Console.WriteLine("The sum of "+num1 +" natural numbers is "+SumNaturalNumber);
		}
		else
		Console.WriteLine("Number is not natural number");
		
		}

  static void Main (string[] args){
  
  Console.WriteLine("Enter the number");
  int num=Convert.ToInt32(Console.ReadLine());
  
  CheckNaturalNumber(num);
  
  }

}