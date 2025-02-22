using System;
using System.Text.RegularExpressions;

class SocialSecurity
{
    static void Main(string[] args)
    {
        Console.WriteLine(Regex.IsMatch("123-45-6789", @"^\d{3}-\d{2}-\d{4}$")); // True
        Console.WriteLine(Regex.IsMatch("123456789", @"^\d{3}-\d{2}-\d{4}$")); // False
    }
}
