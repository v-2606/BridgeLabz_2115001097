using System;

class TemperatureConversion
{
    static void ConvertTemperature(double celsius)
    {
        double fahrenheitResult = (celsius * 9 / 5) + 32;
        Console.WriteLine(celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        ConvertTemperature(celsius);
    }
}
