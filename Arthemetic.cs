//using System;

//class Arthemetic
//{
//    static void Method1(int a, int b)
//    {
//        if (b == 0)
//        {
//            throw new DivideByZeroException("Cannot divide by zero!");
//        }

//        Console.WriteLine($"Result: {a} / {b} = {a / b}");
//    }

//    static void Method2(int a, int b)
//    {
//        Method1(a, b);
//    }

//    static void Main(string[] args)
//    {
//        try
//        {
//            Console.Write("Enter first number: ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.Write("Enter second number: ");
//            int num2 = int.Parse(Console.ReadLine());

//            Method2(num1, num2);
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Error: Please enter valid numeric values.");
//        }
//        finally
//        {
//            Console.WriteLine("Operation completed.");
//        }
//    }
//}
