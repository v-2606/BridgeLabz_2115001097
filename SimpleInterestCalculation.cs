using System;

class SimpleInterestCalculation
{
    static void CalculateSimpleInterest(double principal, double rate, double time)
    {
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time period: ");
        double time = Convert.ToDouble(Console.ReadLine());

        CalculateSimpleInterest(principal, rate, time);
    }
}
