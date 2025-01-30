using System;

class Factorial
{
     
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }
   
    static void DisplayResult(int number, long result)
    {
        Console.WriteLine("The factorial of  " +number + " is " +result);
    }

  static void Main(string [] args)
 {
        Console.Write("Enter numberr : ");
        int number=Convert.ToInt32(Console.ReadLine());
        if(number<0)
        {
         Console.WriteLine(" enter  input:");
         }
        long result = Factorial(number);
        DisplayResult(number, result);
       
 }
 }