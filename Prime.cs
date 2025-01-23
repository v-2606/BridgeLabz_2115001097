using System;

class Prime
{
    static void CheckPrime(int number)
    {
        bool isPrime = true;

        if (number <= 1) 
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++) 
            {
                if (number % i == 0) 
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine("The number " + number + " is a prime number.");
        else
            Console.WriteLine("The number " + number + " is not a prime number.");
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        CheckPrime(number);
    }
}
