using System;

class Check{
	 static int CheckPositive(int num){
		 
		 if(num>0) return 1;
		 
		 else if(num<0) return -1;
		 
		 else  return 0;
		 
	 }
	
	static void Main(string[] args){
		
		int number=Convert.ToInt32(Console.ReadLine());
		
		int Checked = CheckPositive(number);
		
		Console.WriteLine( +Checked);
		
		
		
	}
	
}