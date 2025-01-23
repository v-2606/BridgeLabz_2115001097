using System;

class Armstrong{
	static void armstrong(int num){
	 int copy=num;
	 int sum=0;
	 while (num!=0){
	 
	 int remender=num%10;
	 sum=sum+(remender*remender*remender);
	 num= num/10;
	 }
	 if (sum==copy){
	 Console.WriteLine("it is armstrong Number");
	 }
	 else
	 {
	 Console.WriteLine("it is not a armstrong Number");
	 }
	 
	 }
	 static void Main(String[] args){
		Console.WriteLine("Enter the number");
		int number=Convert.ToInt32(Console.ReadLine());
		
		armstrong(number);
	 
	 }
	
	

}