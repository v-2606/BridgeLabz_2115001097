using System;
public class MultiplicationTable
{
   

    static void PrintMultiplicationTable(int number)
    {
        if (number >= 6 && number <= 9)
        {
            Console.WriteLine("Multiplication Table of :"+number);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(+number+" x "+i +" = " +(number * i));
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 6 and 9.");
        }
    }
	 static void Main(string[] args)
    {
        Console.Write("Enter a number between 6 and 9: ");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintMultiplicationTable(number); 

        
    }
}