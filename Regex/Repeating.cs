//using System;
//using System.Text.RegularExpressions;

//class Repeating
//{
//    static void Main(string[] args)
//    {
//        string text = "This is is a repeated repeated word test.";
//        MatchCollection repeats = Regex.Matches(text, @"\b(\w+)\s+\1\b");

//        foreach (Match repeat in repeats)
//        {
//            Console.WriteLine(repeat.Groups[1].Value);
//        }
//    }
//}
