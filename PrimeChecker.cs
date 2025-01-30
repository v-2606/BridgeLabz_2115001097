using System;

class PrimeChecker
{
   static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
  static void Main(string [] args)
 {
      Console.Write("Enter number : ");
      int number=Convert.ToInt32(Console.ReadLine());
       
            if (IsPrime(number)){
                Console.WriteLine(number +" is  prime number.");
            }
            else{
                Console.WriteLine(number  +" not  prime number.");
            } 
 }
 }