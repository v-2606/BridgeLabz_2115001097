using System;

class StudentFee
{
    static void CalculateFee(double fee, double discountPercent)
    {
        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;

         Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);

        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the student fee (INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the university discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        CalculateFee(fee, discountPercent);
    }
}
