using System;

class TemperatureConversion1
{
    static void ConvertTemperature(double fahrenheit)
    {
        double celsiusResult = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine(fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        ConvertTemperature(fahrenheit);
    }
}
