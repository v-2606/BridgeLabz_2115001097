//using System;
//using System.Text.RegularExpressions;

//class ExtractLinks
//{
//    static void Main(string[] args)
//    {
//        string text = "Visit https://www.google.com and http://example.org for more info.";
//        MatchCollection links = Regex.Matches(text, @"https?://[\w.-]+\.[a-zA-Z]{2,6}");

//        foreach (Match link in links)
//        {
//            Console.WriteLine(link.Value);
//        }
//    }
//}
