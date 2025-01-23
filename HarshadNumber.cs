using System;

class HarshadNumber{
	static void HarshadNum(int num){
	int OriginalNumber=num;
	 int sum=0;
	 while (num!=0){
	 
	 int remender=num%10;
	 sum=sum+remender;
	 num= num/10;
	 
	 }
	 
	if((OriginalNumber%sum)==0)
	 Console.WriteLine("Number is Harshad Number");
	 
	 else
	 {
	 	 Console.WriteLine("Number is Not a Harshad Number");
	 }
	 
	 
	 
	 }
	 static void Main(String[] args){
		Console.WriteLine("Enter the number");
		int number=Convert.ToInt32(Console.ReadLine());
		HarshadNum(number);
	 
	 }
}