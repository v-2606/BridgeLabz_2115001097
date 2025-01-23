using System;

class CheckNumber{
		static void CheckNum(int number){
		if(number>0)
		{
		Console.WriteLine("Number is positive");
		}
		else if(number<0)
		{
		Console.WriteLine("Number is negative");
		}
		else
		Console.WriteLine("Number is 0");
		
		}

  static void Main (string[] args){
  
  Console.WriteLine("Enter the Number");
  int Number=Convert.ToInt32(Console.ReadLine());
  CheckNum( Number);
  
  }

}