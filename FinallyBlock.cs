//using System;

//class FinallyBlock
//{
//    static void PerformDivision()
//    {
//        try
//        {
            
//            Console.Write("Enter the first number: ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.Write("Enter the second number: ");
//            int num2 = int.Parse(Console.ReadLine());

        
//            int result = num1 / num2;

            
//            Console.WriteLine($"Result: {num1} / {num2} = {result}");
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Error: Division by zero is not allowed.");
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

//    static void Main(string[] args)
//    {
//        PerformDivision();
//    }
//}

