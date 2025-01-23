using System;
class NaturalNumber{
		static void CheckNaturalNumber(int num){
		if (num < 0) 
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
            return; 
        }
        int sum = 0;
        int i = 1; 
        for( ; i <= num;i++) 
        {
            sum += i; 
           
        }
		int SumNaturalNumber=num *(num +1) / 2;
		if(sum==SumNaturalNumber){
		 
		Console.WriteLine(+SumNaturalNumber +" and "+ sum +"\n Both are equal");
		}
		else
		Console.WriteLine("Both are not equal");
		
		}

  static void Main (string[] args){
  
  Console.WriteLine("Enter the number");
  int num=Convert.ToInt32(Console.ReadLine());
  
  CheckNaturalNumber(num);
  
  }

}