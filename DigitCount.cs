using System;

class CountDigit{
	static void DigitCount(int num){
	 int count=0;
	 while (num!=0){
	 
	 int remender=num%10;
	 num= num/10;
	 count+=1;
	 }
	
	 Console.WriteLine("Number of digit are :" +count);
	 
	 
	 
	 }
	 static void Main(String[] args){
		Console.WriteLine("Enter the number");
		int number=Convert.ToInt32(Console.ReadLine());
		
		DigitCount(number);
	 
	 }
}