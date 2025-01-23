using System;
class ReverseCount9{
		static void ReverseNuber(int num){
		int i=num;
		for( ;i>=1;i--){
		Console.WriteLine(+i); 
	
		}
		}
		
		static void Main(string[] args){
		Console.WriteLine("enter number");
		int num=Convert.ToInt32(Console.ReadLine());
		ReverseNuber(num);
		
		}
}
