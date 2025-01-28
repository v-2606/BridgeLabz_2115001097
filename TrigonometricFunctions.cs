using System;

 class TrigonometricFunctions
{
    static  double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = Math.PI * angle / 180.0;
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }

    public static void Main(string[] args)
    {
        
 Console.WriteLine("Enter Angle")
        double angle = Convert.ToDouble(Console.ReadLine());
        double[] results = CalculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }
}
