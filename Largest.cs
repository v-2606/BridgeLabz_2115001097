using System;

class Largest{
		static void LargestNumber(int num1, int num2 ,int num3){
		if(num1>num2 && num1>num3){
		Console.WriteLine("Number 1 is largest ");
		}
		else if(num2>num1 && num2>num3){
		Console.WriteLine("Number 2 is largest ");
		}
		else
		Console.WriteLine("Number 3 is largest among 3 number");
		
		}

  static void Main (string[] args){
  
  Console.WriteLine("Enter the number");
  int num1=Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Enter the number 2");
  int num2=Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Enter the number 3");
  int num3=Convert.ToInt32(Console.ReadLine());
  
  LargestNumber(num1, num2 , num3);
  
  }

}