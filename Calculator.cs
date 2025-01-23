using System;
class Calculator{
	static void SwitchCal(double num1, double num2 ,string operation){
	  double result;
	  switch (operation){
	  
	  case "+" :
			result=num1+num2;
			Console.WriteLine("Result of operation + :" +result);
			break;
			
	  case "*" :
			result=num1*num2;
			Console.WriteLine("Result of operation * :" +result);
			break;
	  case "/" :
			if (num2 != 0)
                {
                    result = num1 / num2;
					Console.WriteLine("Result of operation / :" +result);
                   
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
			break;
	  case "-" :
			result=num1-num2;
			Console.WriteLine("Result of operation - :" +result);
			break;
	  }
	 }
	
	 static void Main(String[] args){
		Console.WriteLine("Enter the number1");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number2");
		int number2=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the operation to perform(+,*,-,/)");
		string operation=(Console.ReadLine());
		
		SwitchCal(number1, number2, operation);
	 }
}