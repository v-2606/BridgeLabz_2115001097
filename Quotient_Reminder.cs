using System;
class Quotient_Reminder{
 
    public static int[] QuotientAndReminder(int number1, int number2 )
    {
        int Quotient=number1/number2;
		int reminder=number1%number2;
       
        return new int[] { Quotient, reminder };
    }
   
  

	static void Main(string [] args)
	{
	  
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());


        int[] result = QuotientAndReminder(number1, number2);
		Console.WriteLine("The Quotient number is " +result[0]);
			Console.WriteLine("The reminder number is " +result[1]);
		
		Console.ReadLine();
	 }
}