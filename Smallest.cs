using System;

class Smallest{
		static void SmallNumber(int num1, int num2 ,int num3){
		if(num1<num3){
		Console.WriteLine("yes 1st it is smaller than 3rd number ");
		}
		else
		Console.WriteLine("Not 1st it is Not smaller than 3rd number ");
		
		}

  static void Main (string[] args){
  
  Console.WriteLine("Enter the number");
  int num1=Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Enter the number 2");
  int num2=Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Enter the number 3");
  int num3=Convert.ToInt32(Console.ReadLine());
  
  SmallNumber(num1, num2 , num3);
  
  }

}