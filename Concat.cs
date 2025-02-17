//using System;
//using System.Diagnostics;
//using System.Text;

//class concat
//{
//    static void Main(string[] args)
//    {
//        MeasureTime("String Concatenation", StringConcatenation);
//        MeasureTime("StringBuilder Concatenation", StringBuilderConcatenation);
//    }

//    static void StringConcatenation()
//    {
//        string result = "";
//        for (int i = 0; i < 1000000; i++)
//        {
//            result += "a";
//        }
//    }

//    static void StringBuilderConcatenation()
//    {
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < 1000000; i++)
//        {
//            sb.Append("a");
//        }
//    }

//    static void MeasureTime(string method, Action operation)
//    {
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        operation();
//        stopwatch.Stop();
//        Console.WriteLine($"{method} Time: {stopwatch.ElapsedMilliseconds} ms");
//    }
//}

