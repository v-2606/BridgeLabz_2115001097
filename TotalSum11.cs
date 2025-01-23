using System;
class TotalSum11{
		static void SumTillZeroOrNegative(int num){
		float total=0;
		while((num!=0)){
			
				if (num <= 0) 
            {
                break; 
            }
			
		   total=total+num;
		   Console.WriteLine("enter number");
		 num=Convert.ToInt32(Console.ReadLine());
			
		}
		Console.WriteLine("Total Sum till user enter 0 is :" +total  );
		}
		static void Main(string[] args){
		Console.WriteLine("enter number");
		int num=Convert.ToInt32(Console.ReadLine());
		SumTillZeroOrNegative(num);
		
		}
}
