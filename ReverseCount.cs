using System;

class ReverseCount{
		static void ReverseNuber(int num){
		int i=num;
		while(i!=0){
		Console.WriteLine(+i); 
		i--;
		}
		}
		
		static void Main(string[] args){
		Console.WriteLine("enter number");
		int num=Convert.ToInt32(Console.ReadLine());
		ReverseNuber(num);
		
		}
}