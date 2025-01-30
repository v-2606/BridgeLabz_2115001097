using System;

class MaxOf3
{
    static int GetInput(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Invalid input.");
        }
    }
      static int FindMaximum(int num1, int num2, int num3)
    {
        return Math.Max(num1, Math.Max(num2, num3));
    }
  static void Main(string [] args)
 {
     Console.WriteLine(" maximum of three numbers");
        int num1 = GetInput("Enter first number: ");
        int num2 = GetInput("Enter second number: ");
        int num3 = GetInput("Enter  third number: ");
       
        int max = FindMaximum(num1, num2, num3);
        Console.WriteLine("maximum number : "+max);
 }
 }