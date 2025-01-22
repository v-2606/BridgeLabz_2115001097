using System;

class StudentDiscount
{
   
    static double Discount(int fee, int discountPercent)
    {
        double discount = (discountPercent / 100.0) * fee;

       
        return fee - discount;
    }

    static void Main(string[] args)
    {
        int fee = 125000;
        int discountPercent = 10;

       
        double finalFee = Discount(fee, discountPercent);

        
        double discountAmount = (discountPercent / 100.0) * fee;

        
        Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);

        Console.ReadLine();
    }
}
